using System;
using System.Collections.Generic;
using System.Threading;

namespace Commands {
    public class CommandExit : ICommand {
        public CommandExit () { }

        public string Help () {
            string message = "Exit command does not have any help";
            Console.WriteLine (message);
            return message;
        }

        public void ParseArguments (List<string> args) {

        }

        public string Run () {
            Console.WriteLine ("Application exit in 3 seconds");
            Thread.Sleep (3000);
            Environment.Exit (0);
            return default;
        }
    }

}