using System;
using ConsoleApp.Framework;
using ConsoleAppBase;
using CommandLine;

namespace ConsoleApp.LoggingIntegration
{
    public class LoggingProgram : ConsoleProgram
    {
        private class Options
        {
            [Option("log4net", Required = false,
              HelpText = "Test with log4net.")]
            public bool Log4NetTest { get; set; }
        }

        public override string Description => "Tests Logging Functionality";

        public override string Name => "LogTest";

        public override void Execute(IConsole console, string[] args)
        {
            console.WriteLine("oh, hi!");
            var options = new Options();
            if(!ParseArguments(args, options))
            {
                console.WriteLine("Error");
            }
        }
    }
}
