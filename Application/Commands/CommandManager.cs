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
                    Console.WriteLine (string.Format (Constant.UndefinedCommandMessage, command.Split (' ').ToList ().FirstOrDefault ()));
                    outputString = string.Format (Constant.UndefinedCommandMessage, command.Split (' ').ToList ().FirstOrDefault ());
                } else {
                    outputString = cmd.Run ();
                }
            } catch (Exception) {
                Console.WriteLine (string.Format (Constant.UndefinedCommandMessage, command.Split (' ').ToList ().FirstOrDefault ()));
                outputString = string.Format (Constant.UndefinedCommandMessage, command.Split (' ').ToList ().FirstOrDefault ());
            }

            return outputString;
        }
    }
}