using ConsoleApp.Framework.Input;
using ConsoleApp.Framework.Prompt;

namespace ConsoleApp.Framework
{
    public class InputManager
    {
        private readonly IConsole _console;
        private readonly ICommandPrompt _prompt;
        private readonly IInputModerator _moderator;

        public InputManager(IConsole console,
            ICommandPrompt prompt,
            IInputModerator moderator)
        {
            _console = console;
            _prompt = prompt;
            _moderator = moderator;
        }

        public string ReadInput()
        {
            _prompt.Display(_console);
            var input = _console.ReadLine();
            return _moderator.Modify(input);
        }

    }
}
