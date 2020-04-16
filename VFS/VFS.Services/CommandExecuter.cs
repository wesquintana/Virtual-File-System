using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Services
{
    public class CommandExecuter: ICommandExecuter
    {
        public List<string> CreateDirectory(List<string> commands)
        {
            return new List<string> { "Creation Successful!" };
        }
        public List<string> GetChildren(List<string> commands)
        {

        }
    }
}
