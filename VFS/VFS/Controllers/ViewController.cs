using System;
using System.Collections.Generic;
using System.Text;
using VFS.Services;
using VFS.Models;

namespace VFS
{
    class ViewController
    {
        private readonly CommandParser _cp= new CommandParser(new CommandExecuter());
        private bool _running = true;
        public List<string> Messages = new List<string>();
        public void Run()
        {
            Console.WriteLine(Resources.WelcomeMessage);
            while (_running)
            {
                GetUserInput();
                Print();
            }
        }
        public void GetUserInput()
        {
            Console.Write("?> ");
            string input = Console.ReadLine()+" ";
            Messages.AddRange(_cp.ParseInput(input));
        }
        public void Print()
        {
            foreach(string message in Messages)
            {
                Console.WriteLine(message);
            }
            Messages.Clear();
        }
    }
}
