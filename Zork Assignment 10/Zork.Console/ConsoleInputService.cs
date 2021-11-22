using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    class ConsoleInputService : IInputService 
    {
        public event EventHandler<string> InputReceived;

        public void GetInput()
        {
            string inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString) == false)
            {           
                    InputReceived?.Invoke(this, inputString);
            }
        }
    }
}
