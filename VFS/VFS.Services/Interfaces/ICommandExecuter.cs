using System.Collections.Generic;

namespace VFS.Services
{
    public interface ICommandExecuter
    {
        public List<string> CreateDirectory(List<string> commands);
        IEnumerable<string> GetChildren(object v);
    }
}