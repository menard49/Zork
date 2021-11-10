using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zork.Builder
{
    public partial class NeighborControl : UserControl
    {
        public static readonly Room NoNeighbor = new Room("None");

        public Room Room
        {
            get => _room;
            set
            {
                if (_room != value)
                {
                    _room = value;
                    if (_room != null)
                    {
                        // var neighborList = new List<Room>(Rooms);
                        Rooms.Insert(0, Neighbor);
                        // neighborList.Insert(0, NoNeighbor);
                        neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
                        // neighborComboBox.DataSource = neighborList;
                        neighborComboBox.DataSource = Rooms;

                        if (_room.Neighbors != null)
                        {
                            if (_room.Neighbors.TryGetValue(Direction, out Room neighbor))
                            {
                                Neighbor = neighbor;
                            }
                            else
                            {
                                Neighbor = NoNeighbor;
                            }
                        }
                        else
                        {
                            Neighbor = NoNeighbor;
                        }

                        neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;
                    }
                    else
                    {
                        neighborComboBox.DataSource = null;
                    }
                }
            }
        }

        public BindingList<Room> Rooms { get; set; }

        public NeighborControl(List<Room> rooms, Directions neighborDirection, Room room)
        {
            InitializeComponent();

            // var neighborList = new List<Room>(Rooms);
            rooms.Insert(0, NoNeighbor);
            // neighborComboBox.SelectedIndexChanged -= NeighborComboBox_SelectedIndexChanged;
            neighborComboBox.DataSource = rooms;

            if (_room.Neighbors != null)
            {
                if (_room.Neighbors.TryGetValue(Direction, out Room neighbor))
                {
                    Neighbor = neighbor;
                }
                else
                {
                    Neighbor = NoNeighbor;
                }
            }
            else
            {
                Neighbor = NoNeighbor;
            }

            // neighborComboBox.SelectedIndexChanged += NeighborComboBox_SelectedIndexChanged;
        }

        private void NeighborComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_room != null)
            {
                Room selectedNeighbor = Neighbor;
                if (_room.Neighbors != null)
                {
                    if (selectedNeighbor == NoNeighbor)
                    {
                        _room.Neighbors.Remove(Direction);
                    }
                    else
                    {
                        _room.Neighbors[Direction] = selectedNeighbor;
                    }
                }
                else
                {
                    _room.Neighbors = new Dictionary<Directions, Room>();
                    _room.Neighbors.Add(Direction, selectedNeighbor);
                }
            }
        }

        public Room Neighbor
        {
            get => (Room)neighborComboBox.SelectedItem;
            set => neighborComboBox.SelectedItem = value;
        }

        public NeighborControl()
        {
            InitializeComponent();
        }

        public Directions Direction
        {
            get => _neighborDirection;
            set
            {
                _neighborDirection = value;
                directionTextBox.Text = value.ToString();
            }
        }

        private Room _room;
        private Directions _neighborDirection;
    }
}
