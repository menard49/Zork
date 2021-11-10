using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Zork.Builder
{
    internal class GameViewModel : INotifyPropertyChanged
    {
#pragma warning disable CS0067
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067

        public bool IsGameLoaded { get; set; }

        public string WelcomeMessage
        {
            get => _game.WelcomeMessage;
            set => _game.WelcomeMessage = value;
        }
        public string ExitMessage
        {
            get => _game.ExitMessage;
            set => _game.ExitMessage = value;
        }
        public string StartingLocation
        {
            get => _game.StartingLocation;
            set => _game.StartingLocation = value;
        }
        public BindingList<Room> Rooms { get; set; }

        public Game Game
        {
            set
            {
                if (_game != value)
                {
                    _game = value;
                    if (_game != null)
                    {
                        WelcomeMessage = _game.WelcomeMessage;
                        ExitMessage = _game.ExitMessage;
                        StartingLocation = _game.StartingLocation;
                        Rooms = new BindingList<Room>(_game.World.Rooms);
                    }
                    else
                    {
                        WelcomeMessage = "Welcome to Zork!";
                        ExitMessage = "Thank you for playing!";
                        StartingLocation = "";
                        Rooms = new BindingList<Room>(new List<Room>());
                    }
                }
                // new game
                if (_game == null)
                {
                    WelcomeMessage = "Welcome to Zork!";
                    ExitMessage = "Thank you for playing!";
                    StartingLocation = "";
                    Rooms = new BindingList<Room>(new List<Room>());
                }
            }
        }

        public void SaveGame(string filename)
        {
            if (!IsGameLoaded)
            {
                throw new InvalidOperationException("No game loaded.");
            }

            if (string.IsNullOrWhiteSpace(filename))
            {
                throw new InvalidProgramException("Invalid filename.");
            }

            JsonSerializer serializer = new JsonSerializer
            {
                Formatting = Formatting.Indented
            };
            using (StreamWriter streamWriter = new StreamWriter(filename))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
            {
                serializer.Serialize(jsonWriter, _game);
            }
        }

        private Game _game;
    }
}
