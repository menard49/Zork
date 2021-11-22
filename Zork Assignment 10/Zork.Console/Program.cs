using System;

namespace Zork
{
        class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();

            Game.StartFromFile(gameFilename, input, output);

            while (Game.Instance.IsRunning)
            {
                output.WriteLine(Game.Instance.Player.Location);
                    input.GetInput();
            }
            Console.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}