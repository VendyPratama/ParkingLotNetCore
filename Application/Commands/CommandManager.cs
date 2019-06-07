using System;
using System.Linq;
using Commons;
using Constants;
using Models;

namespace Commands {
    public class CommandManager {
        private readonly Parser _parser;

        public CommandManager (Parser parser) {
            _parser = parser;
        }

        public string Execute (string command) {
            string outputString = string.Empty;
            try {
                var cmd = _parser.Parse (command);
                if (cmd == null) {
                    Console.WriteLine (string.Format (Constant.UndefinedCommandMessage, command.Replace (' ', '-')));
                    outputString = string.Format (Constant.UndefinedCommandMessage, command.Replace (' ', '-'));
                } else {
                    outputString = cmd.Run ();
                }
            } catch (InvalidArgumentException ex) {
                Console.WriteLine (ex.Message);
                outputString = ex.Message;
            } catch (InvalidCommandException) {
                Console.WriteLine (UndefinedMessageWrapper (command));
                outputString = UndefinedMessageWrapper (command);
            } catch (Exception) {
                Console.WriteLine (Constant.UnexpectedErrorMessage);
                outputString = Constant.UnexpectedErrorMessage;
            }

            return outputString;
        }

        public string UndefinedMessageWrapper (string command) {
            var s = string.Format (Constant.UndefinedCommandMessage, command.Replace (' ', '-'));
            return s;
        }
    }
}