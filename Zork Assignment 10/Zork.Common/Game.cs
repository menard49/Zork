using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.IO;

namespace Zork
{
    public class Game : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string StartingLocation { get; set; }
        
        public string WelcomeMessage { get; set; }
        
        public string ExitMessage { get; set; }

        public World World { get; private set; }

        [JsonIgnore]
        public Player Player { get; private set; }

      //  [JsonIgnore]

      //  public CommandManager CommandManager { get; }

        [JsonIgnore]
        public bool IsRunning { get; set; }

        [JsonIgnore]
        
        public IInputService Input { get; private set; }

        [JsonIgnore]
        public IOutputService Output { get; set; }

        public Dictionary<string, Command> Commands { get; private set; }
        public static Game Instance { get; private set; }

        public Game(World world, Player player)
        {
            World = world;
            Player = player;

            Commands = new Dictionary<string, Command>()
            {
                { "QUIT", new Command("QUIT", new string[] { "QUIT", "Q", "BYE" }, Quit) },
                { "LOOK", new Command("LOOK", new string[] { "LOOK", "L" }, Look) },
                { "NORTH", new Command("NORTH", new string[] { "NORTH", "N" }, game => Move(game, Directions.North)) },
                { "SOUTH", new Command("SOUTH", new string[] { "SOUTH", "S" }, game => Move(game, Directions.South)) },
                { "EAST", new Command("EAST", new string[] { "EAST", "E"}, game => Move(game, Directions.East)) },
                { "WEST", new Command("WEST", new string[] { "WEST", "W" }, game => Move(game, Directions.West)) },
                 { "SCORE", new Command("SCORE", new string[] { "SCORE", "SC" }, Score) },
                 { "REWARD", new Command("REWARD", new string[] { "REWARD", "R" }, Reward) }
            };
        }

        private void Reward(Game obj)
        {
            throw new NotImplementedException();
        }

        private void Score(Game game)
        {
            Player.MoveCount++;
            Player.Score++;
            Output.WriteLine($"Your score is {Player.Score}, in {Player.MoveCount} move(s).");
        }

        //  public Game() => CommandManager = new CommandManager();
        public static void StartFromFile(string gameFilename, IInputService input, IOutputService output)
       {
           if (!File.Exists(gameFilename))
           {
               throw new FileNotFoundException("Expected file.", gameFilename);
           }
       
           Start(File.ReadAllText(gameFilename), input, output);
       }


      public static void Start(string gameJsonString, IInputService input, IOutputService output)
     {
          Instance = Load(gameJsonString);
            Instance.Input = input;
            Instance.Output = output;         
            // Instance.DisplayWelcomeMessage();
            Instance.IsRunning = true;
            Instance.Input.InputReceived += Instance.InputReceivedHandler;
             
     }
     
      
        
        private static void Start(string v) => throw new NotImplementedException();
       private static Game Load(string gameJsonString)
       {
           throw new NotImplementedException();
       }

        public void InputReceivedHandler(object sender, string inputString)
        {
            Output.WriteLine(string.IsNullOrWhiteSpace(WelcomeMessage) ? "Welcome to Zork!" : WelcomeMessage);

            IsRunning = true;
            Room previousRoom = null;
            
               Output.WriteLine(Player.Location);
                if (previousRoom != Player.Location)
                {
                    Player.MoveCount++;
                    Look(this);
                    previousRoom = Player.Location;
                }

                Output.Write("\n> ");
                string commandString = Console.ReadLine().Trim().ToUpper();
                Command foundCommand = null;
                foreach (Command command in Commands.Values)
                {
                    if (command.Verbs.Contains(commandString))
                    {
                        Player.Score++;
                        foundCommand = command;
                        break;
                    }
                }

                if (foundCommand != null)
                {
                    Player.MoveCount++;

                    foundCommand.Action(this);
                }
                else
                {
                    Output.WriteLine("Unknown command.");
                }
            

            Output.WriteLine(string.IsNullOrWhiteSpace(ExitMessage) ? "Thank you for playing!" : ExitMessage);
        }

        private static void Move(Game game, Directions direction)
        {
            if (game.Player.Move(direction) == false)
            {
                Console.WriteLine("The way is shut!");
            }
        }


        private static void Look(Game game) => Console.WriteLine(game.Player.Location.Description);

        private static void Quit(Game game) => game.IsRunning = false;


        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World, StartingLocation);
            Player.MoveCount = 0;
            Player.Score = 0;
        }

        public static void Start(string text, object output)
        {
            throw new NotImplementedException();
        }
    }
}