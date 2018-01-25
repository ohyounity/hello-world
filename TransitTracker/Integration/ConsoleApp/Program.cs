using ConsoleApp.Framework;
using System.Collections.Generic;
using Framework.NET.Containers.Extensions;
using ConsoleApp.LoggingIntegration;
using ConsoleApp.Framework.Prompt;
using ConsoleApp.Framework.Input;

namespace ConsoleApp
{
    class Program
    {
        private readonly IDictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

        private Program()
        {
            _commands = CommandFactory.CreateCommands(new ICommand[] { new HelpCommand(this), new LoggingProgram() });
        }

        private class HelpCommand : ICommand
        {
            private readonly Program _program;

            public HelpCommand(Program program)
            {
                _program = program;
            }

            public string Description => "Displays help";

            public string Name => "help";

            public void Execute(IConsole console, string[] args)
            {
                console.WriteLine("Following are available: ");
                _program._commands.ForEach((k, v) => console.WriteLine($"{k} : {v.Description}"));
            }
        }

        static void Main(string[] args)
        {
            var program = new Program();
            program.Execute(args);
        }

        protected void Execute(string[] args)
        {
            var console = new SystemConsole();
            var input = string.Empty;
            var inputHandle = new InputManager(console,
                new BasicCommandPrompt(),
                new MultiInputModerator(new IInputModerator[] { new TrimInputModerator(), new LowerInputModerator() }));
            do
            {
                input = inputHandle.ReadInput();
                if(!string.IsNullOrEmpty(input))
                {
                    ICommand cmd = null;
                    if(_commands.TryGetValue(input, out cmd))
                    {
                        cmd.Execute(console, new string[] { });
                    }
                    else
                    {
                        console.WriteLine("Did not find command: " + input);
                    }
                }
            } while (!string.IsNullOrEmpty(input));
        }
    }
}
