using System.Collections.Generic;

namespace Commands {
    public class CommandInfo : ICommand {
        public CommandInfo () {

        }

        public string Help () { return default; }

        public void ParseArguments (List<string> args) { }

        public string Run () {
            return default;
        }
    }
}