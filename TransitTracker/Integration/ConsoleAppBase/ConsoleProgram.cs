using ConsoleApp.Framework;
using CommandLine;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppBase
{
    public abstract class ConsoleProgram : ICommand
    {
        /*
        public class Options
        {
            [Option('r', "read", Required = true,
              HelpText = "Input files to be processed.")]
            public IEnumerable<string> InputFiles { get; set; }

            // Omitting long name, default --verbose
            [Option(
              HelpText = "Prints all messages to standard output.")]
            public bool Verbose { get; set; }

            [Option(DefaultValue = "中文",
              HelpText = "Content language.")]
            public string Language { get; set; }
        }*/

        public abstract string Description { get; }

        public abstract string Name { get; }

        public abstract void Execute(IConsole console, string[] args);

        protected bool ParseArguments<Options>(string[] args, Options options) where Options : new()
        {
            var isValid = Parser.Default.ParseArguments<Options>(args);
            return isValid.Errors.Any();
        }
    }
}
