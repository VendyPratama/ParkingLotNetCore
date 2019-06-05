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

            if (!command.StartsWith (Constant.InitialCommand))
                throw new ArgumentException ("message", nameof (command));

            var cmdParts = command.Split (' ').ToList ();
            var cmdName = cmdParts[1];
            var arguments = cmdParts.Skip (2).ToList ();

            switch (cmdName) {
                case Constant.ExitCommand:
                    cmd = new CommandExit ();
                    cmd.ParseArguments (arguments);
                    break;
                case Constant.InfoCommand:
                    cmd = new CommandInfo ();
                    cmd.ParseArguments (arguments);
                    break;
                default:
                    return null;
            }

            return cmd;
        }
    }
}