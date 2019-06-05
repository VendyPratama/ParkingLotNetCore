using System.Collections.Generic;

namespace Commands {
    public interface ICommand {
        void Run ();
        void Help ();
        void ParseArguments (List<string> args);
    }
}