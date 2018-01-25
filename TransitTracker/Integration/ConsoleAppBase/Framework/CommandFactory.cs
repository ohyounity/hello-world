using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Framework
{
    public static class CommandFactory
    {
        public static IDictionary<string, ICommand> CreateCommands(IEnumerable<ICommand> cmds)
        {
            return cmds.ToDictionary(c => c.Name.ToLower());
        }
    }
}
