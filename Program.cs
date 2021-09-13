using System;

namespace Zork
{
    class Program
    {
        private static string Location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

           
            while (true)
            {
                Console.Write($"{Rooms[LocationColumn]}\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim().ToUpper());
                if (command == Commands.QUIT)
                {
                    break;
                }

                string outputString;
                switch (command)
                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door. \n A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                       if(Move(command))
                        {
                            outputString = $"You moved {command}.";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;
             
                    default:
                        outputString = "Unknown command";
                        break;
                }

                Console.WriteLine(outputString);
            }

            Console.WriteLine("Finished.");
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {               
                case Commands.NORTH:
                case Commands.SOUTH:            
                    break;

                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                        LocationColumn++;
                        didMove = true;
                        break;
                                                                     
                case Commands.WEST when LocationColumn > 0:                  
                        LocationColumn--;
                        didMove = true;                                  
                        break;               
            }
            return didMove;
        }
        private static Commands ToCommand(string commandString) => (Enum.TryParse<Commands>(commandString, out Commands result) ? result : Commands.UNKNOWN);

        private static string[] Rooms = { "Forrest", "West of House", "Behind House", "Clearing", "Canyon View" };
        private static int LocationColumn = 1;
    }
}

// private static readonly string [,] Rooms = {
    // { "Rocky Trail", "South of House", "Canyon View"},
    // { "Forest", "West of HOuse", "Behind House"},
    // ( "Dense Woods", "North of House", "Clearing" }
    // };