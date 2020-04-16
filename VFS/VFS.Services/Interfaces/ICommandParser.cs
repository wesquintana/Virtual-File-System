using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Services.Interfaces
{
    public interface ICommandParser
    {
        public List<string> ParseInput(string rawInput);
    }
}
