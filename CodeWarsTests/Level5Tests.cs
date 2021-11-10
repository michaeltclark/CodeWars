using CodeWarsLib.lvl5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeWarsTests
{
    public class Level5Tests
    {
        [Fact]
        public void TestConnect4()
        {
            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(1)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 3
            Assert.Equal("Player 1 has a turn", Connect4.Play(1)); // 4
            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 5
            Assert.Equal("Column full!", Connect4.Play(1)); // Full

            Assert.Equal("Player 1 has a turn", Connect4.Play(2)); // 1
            Assert.Equal("Player 2 has a turn", Connect4.Play(3)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(2)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(3)); // 2
            Assert.Equal("Player 1 has a turn", Connect4.Play(2)); // 3
            Assert.Equal("Player 2 has a turn", Connect4.Play(3)); // 3
            Assert.Equal("Player 2 wins!", Connect4.Play(2)); // 4

            Connect4.Reset();

            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(1)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 3
            Assert.Equal("Player 1 has a turn", Connect4.Play(1)); // 4
            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 5
            Assert.Equal("Column full!", Connect4.Play(1)); // Full

            Connect4.Reset();

            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(1)); // 1
            Assert.Equal("Player 2 has a turn", Connect4.Play(2)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(2)); // 1
            Assert.Equal("Player 2 has a turn", Connect4.Play(3)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(3)); // 1
            Assert.Equal("Player 1 wins!", Connect4.Play(4)); // 1

            Connect4.Reset();

            Assert.Equal("Player 2 has a turn", Connect4.Play(1)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(2)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(2)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(3)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(3)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(4)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(3)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(4)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(4)); // 1
            Assert.Equal("Player 1 has a turn", Connect4.Play(6)); // 2
            Assert.Equal("Player 2 has a turn", Connect4.Play(4)); // 1
            Assert.Equal("Player 1 wins!", Connect4.Play(4)); // 1

        }
    }
}
