using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAssignment
{
    public static class Functions
    {
        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int SubtractTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
#error oh no I broke this!
        }
    }
}
