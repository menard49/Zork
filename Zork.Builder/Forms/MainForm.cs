using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private bool IsGameLoaded
        {
            get
            {
                return _viewModel.IsGameLoaded;
            }
            set
            {
                _viewModel.IsGameLoaded = value;

                foreach (var control in _gameDependentControls)
                {
                    control.Enabled = _viewModel.IsGameLoaded;
                }

                foreach (var menuItem in _gameDependentMenuItem)
                {
                    menuItem.Enabled = _viewModel.IsGameLoaded;
                }
            }
        }
        private GameViewModel ViewModel
        {
            get => _viewModel;
            set
            {
                if (_viewModel != value)
                {
                    _viewModel = value;
                    gameViewModelBindingSource.DataSource = _viewModel;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new GameViewModel();
            gameViewModelBindingSource.DataSource = ViewModel;

            _neighborControlMap = new Dictionary<Directions, NeighborControl>
            {
                { Directions.North, northNeighborControl },
                { Directions.South, southNeighborControl },
                { Directions.East, eastNeighborControl },
                { Directions.West, westNeighborControl }
            };

            _gameDependentControls = new Control[]
            {
                roomsListBox,
                addRoomButton,
                startingComboBox,
                roomInfoGroupBox
            };

            _gameDependentMenuItem = new ToolStripMenuItem[]
            {
                closeGameToolStripMenuItem,
                saveToolStripMenuItem,
                saveAsToolStripMenuItem
            };

            IsGameLoaded = false;
        }

        #region EventHandlers
        private void newMenu_Click(object sender, EventArgs e)
        {
            ViewModel.Game = null;
            IsGameLoaded = true;
            openFilename = null;
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);
                    openFilename = openFileDialog.FileName;
                    ViewModel.Game = JsonConvert.DeserializeObject<Game>(jsonString);
                    IsGameLoaded = true;

                    Room selectedRoom = roomsListBox.SelectedItem as Room;
                    foreach (KeyValuePair<Directions, NeighborControl> entry in _neighborControlMap)
                    {
                        entry.Value.Rooms = ViewModel.Rooms;
                        entry.Value.Room = selectedRoom;
                    }

                    Room startingRoom = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(ViewModel.StartingLocation, StringComparison.OrdinalIgnoreCase));
                    if (startingRoom != null)
                    {
                        startingComboBox.SelectedItem = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(ViewModel.StartingLocation, StringComparison.OrdinalIgnoreCase));
                    }
                    else
                    {
                        startingComboBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFilename != null)
            {
                _viewModel.SaveGame(openFilename);
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFilename = saveFileDialog.FileName;
                _viewModel.SaveGame(openFilename);
            }
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            using (AddRoomForm addRoomForm = new AddRoomForm())
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    if (ViewModel.Rooms != null)
                    {
                        Room existingRoom = ViewModel.Rooms.FirstOrDefault(room => room.Name.Equals(addRoomForm.RoomName, StringComparison.OrdinalIgnoreCase));
                        if (existingRoom != null)
                        {
                            MessageBox.Show("Room already exists", "Zork Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Room room = new Room(addRoomForm.RoomName);
                            ViewModel.Rooms.Add(room);
                        }
                    }
                }
            }
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            ViewModel.Rooms.Remove((Room)roomsListBox.SelectedItem);
            roomsListBox.SelectedItem = ViewModel.Rooms.FirstOrDefault();
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteRoomButton.Enabled = roomsListBox.SelectedItem != null;
            Room selectedRoom = roomsListBox.SelectedItem as Room;
            foreach (KeyValuePair<Directions, NeighborControl> entry in _neighborControlMap)
            {
                entry.Value.Room = selectedRoom;
            }
        }

        private void startingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Room selectedRoom = startingComboBox.SelectedItem as Room;
            if (selectedRoom != null)
            {
                ViewModel.StartingLocation = selectedRoom.Name;
            }
        }
        #endregion EventHandlers

        private GameViewModel _viewModel;
        private Control[] _gameDependentControls;
        private ToolStripMenuItem[] _gameDependentMenuItem;
        private string openFilename;
        private readonly Dictionary<Directions, NeighborControl> _neighborControlMap;

    }
}
