using System;
using System.Collections.Generic;
using System.Threading;

namespace Commands {
    public class CommandExit : ICommand {
        public CommandExit () { }

        public void Help () {
            Console.WriteLine ("Exit command does not have any help");
        }

        public void ParseArguments (List<string> args) {

        }

        public void Run () {
            Console.WriteLine ("Application exit in 3 seconds");
            Thread.Sleep (3000);
            Environment.Exit (0);
        }
    }

}