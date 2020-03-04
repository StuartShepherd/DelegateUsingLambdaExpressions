using System;

namespace DelegateUsingLambdaExpressions
{
    class Program
    {
        public delegate double MathDelegate(double value1, double value2);

        static void Main(string[] args)
        {
            Console.WriteLine("Delegate using Lambda Expressions");
            Console.WriteLine("Sometimes the whole signature of a method can be more code than the body of a method. There are also situations in which you need to create an entire method only to use it in a delegate.");
            Console.WriteLine();

            // output result is 7   
            MathDelegate mathAddDelegate = (x, y) => x + y;
            var result = mathAddDelegate(5, 2);
            Console.WriteLine(result);

            // output result is 3
            MathDelegate mathSubtractDelegate = (x, y) => x - y; ;
            result = mathSubtractDelegate(5, 2);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}