namespace ConsoleApp.Framework
{
    public interface IConsole
    {
        string ReadLine();
        void WriteLine(string output);
        void Write(string output);
    }
}
