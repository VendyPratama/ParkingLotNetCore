using System;
using Commons;
using Models;

namespace Commands {
    public static class Runner {
        public static void Run () {
            CommandManager commnadManager = new CommandManager (new Parser ());
            while (true) {
                var commandInput = Console.ReadLine ();
                commnadManager.Execute (commandInput);
            }
        }
    }
}