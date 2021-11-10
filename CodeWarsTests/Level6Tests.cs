using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using CodeWarsLib.lvl6;

namespace CodeWarsTests
{
    public class Level6Tests
    {


        [Fact]
        public void TestBitCounting()
        {
            Assert.Equal(5, BitCounting.Run(1234));
        }

        [Fact]
        public void TestADisguisedSequence()
        {
            Assert.Equal(1, ADisguisedSequence.Run(0));
            Assert.Equal(131072, ADisguisedSequence.Run(17));
            Assert.Equal(2097152, ADisguisedSequence.Run(21));
        }

        [Fact]
        public void TestBallUpward()
        {
            Assert.Equal(4, BallUpwards.Run(15));
            Assert.Equal(7, BallUpwards.Run(25));
            Assert.Equal(13, BallUpwards.Run(45));
        }

        [Fact]
        public void TestHandshakeProblem()
        {
            Assert.Equal(4, HandshakeProblem.Run(6));
            Assert.Equal(5, HandshakeProblem.Run(7));
            Assert.Equal(5, HandshakeProblem.Run(8));
            Assert.Equal(5, HandshakeProblem.AcceptedSolution(8));
        }

        [Fact]
        public void TestIPAddresses()
        {
            Assert.False(IPValidation.Run("d.179.92.142"));
            Assert.False(IPValidation.Run("12.34.56 .1"));
            Assert.False(IPValidation.Run("123.045.067.089"));
            Assert.False(IPValidation.Run("1.2.3"));
            Assert.False(IPValidation.Run("1.2.3.4.5"));
            Assert.False(IPValidation.Run("123.456.78.90"));
            Assert.False(IPValidation.Run("abc.def.ghi.jkl"));
            Assert.False(IPValidation.Run("12.34.56"));
            Assert.False(IPValidation.Run("12.34.56.00"));

            Assert.True(IPValidation.Run("1.2.3.4"));
            Assert.True(IPValidation.Run("123.45.67.89"));
        }
    }
}
