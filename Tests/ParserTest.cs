using System;
using Commands;
using Commons;
using Xunit;

namespace Tests {
    public class ParserTest {
        private readonly Parser _parser;

        public ParserTest () {
            _parser = new Parser ();
        }

        [Fact]
        public void Parser_ShouldThrows () {
            Assert.Throws<ArgumentNullException> (() => _parser.Parse (null));
        }

        [Fact]
        public void Parser_ShouldReturnCommandExit () {
            var cmd = _parser.Parse ("exit");
            Assert.True (cmd is CommandExit);
        }

        [Fact]
        public void Parser_ShouldReturnCommandPark () {
            var cmd = _parser.Parse ("park");
            Assert.True (cmd is CommandPark);
        }

        [Fact]
        public void Parser_ShouldReturnCommandHelp () {
            var cmd = _parser.Parse ("help");
            Assert.True (cmd is CommandHelp);
        }
    }
}