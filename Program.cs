﻿using System;
using System.ComponentModel.Design;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            Commands command = ToCommand(inputString.Trim().ToUpper());
            Console.WriteLine(command);
        }

        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse<Commands>(commandString, out Commands command) ? command : Commands.UNKNOWN; 
        }
    }
}
