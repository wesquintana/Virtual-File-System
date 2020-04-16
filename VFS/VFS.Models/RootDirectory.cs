using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Models
{
    class RootDirectory:IDirectoryItem
    {
        public string Name { get; }

        public RootDirectory()
        {
            Name = "Root";
        }
    }
}
