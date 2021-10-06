using System;
using System.IO;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {       
        static void Main(string[] args)
        {      
           const string defaultGameFilename = "Zork.json";
           string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
            
            Console.WriteLine("Welcome to Zork!");
            game.Run();                    
        }
        private enum CommandLineArguments
        {
            GameFilename = 0           
        }      

     //  private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN; //commandString, ignoreCase: true, add ignoreCase
     //  private static void InitializeRooms(string roomsFilename) =>
     //      Rooms = JsonConvert.DeserializeObject<Room[,]>(File.ReadAllText(roomsFilename));      //  {
     //
     //  private static Room[,] Rooms =
     //  {
     //      {new Room ( "Rocky Trail"),new Room ("South of House"), new Room ( "Canyon View")},
     //      {new Room ( "Forest"),     new Room ("West of House"),  new Room ( "Behind House")},
     //      {new Room ( "Dense Woods"),new Room ("North of House"), new Room (  "Clearing") }
     //  };
     //  private static bool IsDirection(Commands command) => Directions.Contains(command);
     //
     //   private static readonly List<Commands> Directions = new List<Commands> 
     //  //private static readonly Commands[] Directions = 
     //  {
     //      Commands.NORTH,
     //      Commands.SOUTH,
     //      Commands.EAST,
     //      Commands.WEST
     //  };
     //  private enum Fields
     //  {
     //      Name = 0,
     //      Description
     //  }
    }//
}
