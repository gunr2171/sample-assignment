using SampleAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests
{
    public class Class1
    {
        [Fact]
        public void AddTwoNumbers()
        {
            var n1 = 1;
            var n2 = 2;
            var expected = 3;
            var actual = Functions.AddTwoNumbers(n1, n2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddTwoNumbers_ExposingFlaw()
        {
            var n1 = 4;
            var n2 = 5;
            var expected = 9;
            var actual = Functions.AddTwoNumbers(n1, n2);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubtractTwoNumbers()
        {
            var n1 = 10;
            var n2 = 6;
            var expected = 4;
            var actual = Functions.SubtractTwoNumbers(n1, n2);
            Assert.Equal(expected, actual);
        }
    }
}
