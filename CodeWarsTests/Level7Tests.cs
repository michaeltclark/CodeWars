using CodeWarsLib;
using CodeWarsLib.lvl7;
using System;
using Xunit;

namespace CodeWarsTests
{
    public class Level7Tests
    {
        [Fact]
        public void TestSumOfIntegersInString()
        {
            Assert.Equal(16, SumOfIntegersInString.Run("12.4"));
            Assert.Equal(31, SumOfIntegersInString.Run("11asdfasdfasdfasdf20"));
            Assert.Equal(100, SumOfIntegersInString.Run("91 9"));
        }

        [Fact]
        public void TestLastSurvivor()
        {
            Assert.Equal("a", LastSurvivor.Run("abc", new int[] { 2, 1 }));
            Assert.Equal("c", LastSurvivor.Run("abc", new int[] { 1, 0 }));
        }

        [Fact]
        public void TestMumbling()
        {
            Assert.Equal("A-Bb-Ccc-Dddd", Mumbling.Run("abcd"));
        }

        [Fact]
        public void TestScalingOfStrings()
        {
            Assert.Equal("aabbccdd\neeffgghh", ScalingOfStrings.Run("abcd\nefgh", 2, 1));
            Assert.Equal("Kj\nSH", ScalingOfStrings.Run("Kj\nSH", 1, 1));
            Assert.Equal("Kj\nKj\nSH\nSH", ScalingOfStrings.Run("Kj\nSH", 1, 2));
        }

        [Fact]
        public void TestHighestAndLowest()
        {
            Assert.Equal("42 -9", HighestAndLowest.Run("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
            Assert.Equal("9 0", HighestAndLowest.Run("9"));
            Assert.Equal("0 -9", HighestAndLowest.Run("-9"));
        }

        [Fact]
        public void TestIntegerDifference()
        {
            Assert.Equal(0, IntegerDifference.Run(new int[] { 1 }, 1));
            Assert.Equal(6, IntegerDifference.Run(new int[] { 1, 1, 1, 1 }, 0));
            Assert.Equal(1, IntegerDifference.Run(new int[] { 0, 1 }, 1));
            Assert.Equal(3, IntegerDifference.Run(new int[] { 1, 1, 5, 6, 9, 16, 27 }, 4));
            Assert.Equal(4, IntegerDifference.Run(new int[] { 1, 1, 3, 3 }, 2));
        }

        [Fact]
        public void TestPandemia()
        {
            Assert.Equal("XX111XX0", Pandemia.PandemicEnsue("XX011XX0"));
            int tolerance = 9;
            Assert.Equal(100d, Pandemia.Run("X100"), tolerance);
            Assert.Equal(50d, Pandemia.Run("X1X0"), tolerance);
            Assert.Equal(0d, Pandemia.Run("XXXX"), tolerance); 
            Assert.Equal(0d, Pandemia.Run("XXXX"), tolerance);
            Assert.Equal(66.666666667, Pandemia.Run("X00X1100"), tolerance);
            Assert.Equal(70d, Pandemia.Run("010X000X1100"), tolerance);
            Assert.Equal(80d, Pandemia.Run("1111000000X000011X0000"), tolerance);


            Assert.Equal("111", Pandemia.PandemicEnsue("010"));
            Assert.Equal("111", Pandemia.PandemicEnsue("100"));
            Assert.Equal("111", Pandemia.PandemicEnsue("001"));
            Assert.Equal("000", Pandemia.PandemicEnsue("000"));
            Assert.Equal("0X0", Pandemia.PandemicEnsue("0X0"));
            Assert.Equal("XXX", Pandemia.PandemicEnsue("XXX"));
            
        }

        [Fact]
        public void TestReverseWords()
        {
            Assert.Equal("sihT si na !elpmaxe", ReverseWords.Run("This is an example!"));
        }
    }
}
