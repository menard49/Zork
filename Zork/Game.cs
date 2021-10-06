using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace Zork
{
    public  class Game
    {
        
        public World World { get; set; } 

        public string StartingLocation { get; set; }

        [JsonIgnore]
        public Player Player { get; set; }

        // [JsonIgnore]
        // public bool IsRunning { get; set; }

        // public string WelcomeMessage { get; set; }

        [OnDeserialized]

        private void OnDeserialized(StreamingContext context)
        {
            Player = new Player(World);
            Player.CurrentRoom = World.RoomsByName[StartingLocation];
        }

        
       // public Game(World world, Player player)
       // {
       //     World = world;
       //     Player = player;
       // }

        public void Run()
        {

            Commands command = Commands.UNKNOWN;
             // IsRunning = true;
             while (command != Commands.QUIT)
             {
                 Console.WriteLine(Player.CurrentRoom);
                 if (Player.PreviousRoom != Player.CurrentRoom)
                 {
                     Console.WriteLine(Player.CurrentRoom.Description);
                     Player.PreviousRoom = Player.CurrentRoom;
                 }
            
                 Console.Write("\n>");
                 command = ToCommand(Console.ReadLine().Trim());
            
                 switch (command)
                 {
                     case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                         break;
            
                     case Commands.LOOK:
                         Console.WriteLine(Player.CurrentRoom.Description);
                         break;
            
                     case Commands.NORTH:
                     case Commands.SOUTH:
                     case Commands.EAST:
                     case Commands.WEST:
                        Directions direction = Enum.Parse<Directions>(command.ToString(), true);
                         if (Player.Move(direction) == false)
                         {
                             Console.WriteLine("The way is shut!");
                         }
                         break;
            
                     default:
                         Console.WriteLine("Unknown command");
                         break;
                 }
             }
        }

       // public static Game Load(string filename)
       // {
       //     Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(filename));
       //     game.Player = game.World.SpawnPlayer();
       //
       //     return game;
       // }

        private static Commands ToCommand(string commandString) => Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
