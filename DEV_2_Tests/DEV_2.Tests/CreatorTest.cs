using System;
using Xunit;
using DEV_2;

namespace DEV_2.Tests
{
    public class CreatorTest
    {
        [Fact]
        public void Output_EmptyString_Null()
        {
            string enteredString = string.Empty;
            Creator c = new Creator(enteredString);
            Assert.Null(c.CreateSequenceOfOddSymbol(enteredString));
        }

        [Fact]
        public void OutputElements_enteredString_OddElements()
        {
            string enteredString = "Elizaveta";
            string outputString = "Eiaea";
            Creator c = new Creator(enteredString);
            Assert.Equal(c.CreateSequenceOfOddSymbol(enteredString), outputString);
        }

        [Fact]
        public void OutputElements_oneElement_oneElement()
        {
            string enteredString = "E";
            string outputString = "E";
            Creator c = new Creator(enteredString);
            Assert.Equal(c.CreateSequenceOfOddSymbol(enteredString), outputString);
        }

        public void OutputSttring_typeString_typeString()
        {
            string enteredString = "Elizaveta";
            Creator c = new Creator(enteredString);
            Assert.IsType(typeof(String), c.CreateSequenceOfOddSymbol(enteredString));
        }
    }
}

