using System.Collections.Generic;

namespace Commands {
    public class CommandHelp : ICommand {
        public CommandHelp () { }

        public string Help () {
            throw new System.NotImplementedException ();
        }

        public void ParseArguments (List<string> args) {
        }

        public string Run () {
            throw new System.NotImplementedException ();
        }
    }
}