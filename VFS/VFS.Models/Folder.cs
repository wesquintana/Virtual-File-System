using System;
using System.Collections.Generic;
using System.Text;

namespace VFS.Models
{
    class Folder : IDirectoryItem
    {
        public string Name { get; }
        private IDirectoryItem Parent { get; }
        
        public Folder(string name, IDirectoryItem parent)
        {
            Name = name;
            Parent = parent;
        }
    }
}
