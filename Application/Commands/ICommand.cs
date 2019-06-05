using System.Collections.Generic;

namespace Commands {
    public interface ICommand {
        string Run ();
        string Help ();
        void ParseArguments (List<string> args);
    }
}