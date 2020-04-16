using System;
using System.Collections.Generic;
using System.Text;
using VFS.Models;

namespace VFS.Services
{
    public class CommandExecuter: ICommandExecuter
    {
        public List<string> CreateDirectory(List<string> commands)
        {
            return new List<string> { Resources.CreationSuccess };
        }
        public List<string> GetChildren(List<string> commands)
        {

        }
    }
}
