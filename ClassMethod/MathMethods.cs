using System;
using System.Linq;

namespace ClassMethod
{
    public class MathMethods
    {
        // Property to store the value after division
        public int Value { get; private set; }

        // Create a void method that divides the input by 2 and stores it in Value
        public void MathOp(int dividend)
        {
            Value = dividend / 2;
        }

        // Method with output parameters
        public string StringCounter(string input, out int count)
        {
            count = input.Length;
            return $"The input string '{input}' has {count} characters.";
        }

        // Overloaded method that returns only the length of the string
        public int StringCounter(string input)
        {
            return input.Length;
        }
    }

    // Declare a static class
    public static class MathUtility
    {
        // Static method that counts occurrences of 'i' or 'I' in the input string
        public static int IFinder(string input)
        {
            return input.Count(c => c == 'i' || c == 'I');
        }
    }
}
