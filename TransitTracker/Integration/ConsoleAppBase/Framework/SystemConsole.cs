using System;

namespace ConsoleApp.Framework
{
    public class SystemConsole : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string output)
        {
            Console.Write(output);
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}
