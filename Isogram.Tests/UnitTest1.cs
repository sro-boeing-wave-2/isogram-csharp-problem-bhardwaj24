using System;
using Xunit;
using Isogram;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Emptystring()
        {
            bool actual = Class1.Isogram1("");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Isogramlowercase()
        {
            bool actual = Class1.Isogram1("isogram");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Elevenword()
        {
            bool actual = Class1.Isogram1("eleven");
            bool expected = false;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Longreportedenglishword()
        {
            bool actual = Class1.Isogram1("subdermatoglyphic");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Duplicatedcharacterinmixedcase()
        {
            bool actual = Class1.Isogram1("Alphabet");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Hyphen()
        {
            bool actual = Class1.Isogram1("thumbscrew-japingly");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Duplicatedhyphen()
        {
            bool actual = Class1.Isogram1("six-year-old");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
        [Fact]
        public void Wordwithspaces()
        {
            bool actual = Class1.Isogram1("thumb screw japingly");
            bool expected = true;
            Assert.Equal(actual, expected);
        }
    }
}
