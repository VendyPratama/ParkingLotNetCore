using System;

namespace Commons {
    public class InvalidCommandException : Exception {
        public InvalidCommandException () { }

        public InvalidCommandException (string message) : base (message) { }
    }
}