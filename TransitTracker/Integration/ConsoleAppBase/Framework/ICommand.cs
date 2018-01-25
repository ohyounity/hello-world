namespace ConsoleApp.Framework
{
    public interface ICommand
    {
        void Execute(IConsole console, string[] args);
        string Description { get; }
        string Name { get; }
    }
}
