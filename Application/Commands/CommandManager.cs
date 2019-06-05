using System;
using Commons;
using Constants;
using Models;

namespace Commands {
    public class CommandManager {
        public CommandManager () { }

        public void Help () {
            throw new System.NotImplementedException ();
        }

        public void Run () {
            while (true) {
                string command = Console.ReadLine ();
                try {
                    var cmd = Parser.Parse (command);
                    if (cmd == null)
                        Console.WriteLine (Constant.UndefinedCommandMessage);
                    else {
                        cmd.Run ();
                    }
                } catch (Exception) {
                    Console.WriteLine (Constant.UndefinedCommandMessage);
                }
            }
        }
    }
}