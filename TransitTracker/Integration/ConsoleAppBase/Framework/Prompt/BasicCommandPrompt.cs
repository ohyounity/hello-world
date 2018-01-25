namespace ConsoleApp.Framework.Prompt
{
    public class BasicCommandPrompt : ICommandPrompt
    {
        public void Display(IConsole console)
        {
            console.Write("> ");
        }
    }
}
