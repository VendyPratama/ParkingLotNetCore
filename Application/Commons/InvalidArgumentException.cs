using System;

namespace Commons {
    public class InvalidArgumentException : Exception {
        public InvalidArgumentException () { }

        public InvalidArgumentException (string message) : base (message) { }
    }
}