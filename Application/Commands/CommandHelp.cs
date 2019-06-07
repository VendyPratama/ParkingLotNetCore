using System;
using System.Collections.Generic;
using System.Text;

namespace Commands {
    public class CommandHelp : ICommand {
        public CommandHelp () { }

        public string Help () {
            StringBuilder sb = new StringBuilder ();
            sb.Append ("**List command parkinglot application\n");
            sb.Append ("\texample:\n");
            sb.Append ("\t\tpark [vehicle number] [color (optional)]");
            return sb.ToString ();
        }

        public void ParseArguments (List<string> args) { }

        public string Run () {
            string msg = Help ();
            Console.WriteLine (msg);
            return msg;
        }
    }
}