using System;
using System.Linq;
using Commands;
using Constants;

namespace Commons {
    public class Parser {
        public Parser () {

        }

        public ICommand Parse (string command) {
            if (string.IsNullOrWhiteSpace (command))
                throw new ArgumentNullException ("message", nameof (command));
            ICommand cmd = null;

            var cmdParts = command.Split (' ').ToList ();
            var cmdName = cmdParts[0];
            var arguments = cmdParts.Skip (1).ToList ();

            switch (cmdName) {
                case Constant.ExitCommand:
                    cmd = new CommandExit ();
                    cmd.ParseArguments (arguments);
                    break;
                case Constant.ParkCommand:
                    cmd = new CommandPark ();
                    cmd.ParseArguments (arguments);
                    break;
                case Constant.HelpCommand:
                    cmd = new CommandHelp ();
                    break;
                default:
                    return null;
            }

            return cmd;
        }
    }
}