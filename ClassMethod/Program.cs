using System;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathMethods class
            MathMethods math = new MathMethods();

            // Have the user enter a number
            Console.WriteLine("Input a number:");
            int dividend = Convert.ToInt32(Console.ReadLine());

            // Call the void method that divides the number by 2
            math.MathOp(dividend);

            // Display the output to the screen
            Console.WriteLine("The result of dividing your number by 2 is: " + math.Value);
            Console.ReadLine();

            // Call the method with output parameters
            Console.WriteLine("Input a phrase:");
            string input = Console.ReadLine();
            string phrase = math.StringCounter(input, out int count);
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            Console.ReadLine();

            // Call the overloaded method
            Console.WriteLine("Input another phrase:");
            string input2 = Console.ReadLine();
            int phrase2_len = math.StringCounter(input2);
            Console.WriteLine("This phrase is " + phrase2_len + " characters long");
            Console.ReadLine();

            // Call the method of the static class
            Console.WriteLine("Input another phrase:");
            string input3 = Console.ReadLine();
            int i_count = MathUtility.IFinder(input3);
            Console.WriteLine("This phrase has " + i_count + " 'i's in it.");
            Console.ReadLine();
        }
    }
}

