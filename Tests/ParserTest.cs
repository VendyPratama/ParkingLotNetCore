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
        public void Parser_ShouldThrowsWhenStartWithNotEqualToInitialCommand () {
            Assert.Throws<ArgumentException> (() => _parser.Parse ("plat exit"));
        }

        [Fact]
        public void Parser_ShouldReturnCommandExit () {
            var cmd = _parser.Parse ("plot exit");
            Assert.True (cmd is CommandExit);
        }

        [Fact]
        public void Parser_ShouldReturnCommandInfo () {
            var cmd = _parser.Parse ("plot info");
            Assert.True (cmd is CommandInfo);
        }
    }
}