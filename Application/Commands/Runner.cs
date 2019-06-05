using System;
using Commons;
using Models;

namespace Commands {
    public static class Runner {
        public static void Run () {
            while (true) {
                var commandInput = Console.ReadLine ();
                CommandManager commnadManager = new CommandManager (new Parser ());
                commnadManager.Execute (commandInput);
            }
        }
    }
}