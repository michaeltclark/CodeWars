using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CodeWarsLib.Algorithms;

namespace CodeWarsTests
{
    public class AlgorithmsTests
    {
        [Fact]
        public void TestStringReversal()
        {
            Assert.Equal("!iH", StringReversal.Reverse("Hi!"));
        }

        [Fact]
        public void TestStringReversalWithArray()
        {
            Assert.Equal("!iH", StringReversal.ReverseWithArray("Hi!"));
        }

        [Fact]
        public void TestWordReversal()
        {
            Assert.Equal("olleH dlroW", StringReversal.ReverseWord("Hello World"));
        }
    }
}
