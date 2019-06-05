using System.Collections.Generic;

namespace Commands {
    public class CommandHelp : ICommand {
        public CommandHelp () { }

        public string Help () {
            string msg = "";
            return msg;
        }

        public void ParseArguments (List<string> args) { }

        public string Run () {
            string msg = string.Empty;
            return msg;
        }
    }
}