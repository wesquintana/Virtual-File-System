using System;

namespace VFS.Models
{
    public class Directory: IDirectoryItem
    {
        public string Name { get; set; }
        public IDirectoryItem Parent;
        public Directory(string name, IDirectoryItem parent)
        {
            Name = name;
            Parent = parent;
        }
    }
}
