using System;
using System.Collections.Generic;
using System.Text;
using VFS.Services.Interfaces;

namespace VFS.Services
{
    public class CommandParser:ICommandParser
    {
        private readonly ICommandExecuter _ce;
        public CommandParser(ICommandExecuter ce)
        {
            _ce = ce;
        }
        public List<string> ParseInput(string rawInput)
        {
            List<string> messages = new List<string>();
            List<string> parsedInput = new List<string>();
            string inputCopy = rawInput;
            while(inputCopy.Length>0)
            {
                parsedInput.Add(inputCopy.Substring(0, inputCopy.IndexOf(" ")));
                inputCopy = inputCopy.Substring(inputCopy.IndexOf(" ")+1);
            }
            switch (parsedInput[0])
            {
                case "mkdir":
                    messages.AddRange(_ce.CreateDirectory(parsedInput));
                    break;
                case "ls":
                    parsedInput.RemoveAt(0);
                    messages.AddRange(_ce.GetChildren(parsedInput));
                    break;
                default:
                    messages.Add(string.Join(" ", (parsedInput)) + " is not a valid command.");
                    break;
            }
            return messages;
        }
    }
}
