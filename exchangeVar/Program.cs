using System;

namespace exchangeVar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The exchangeVar method exchange the value of the variables a and b without defining the third variable.");
            ExchangeVarables.ExchangeVar();



            var a = 5;
            var b = 10;
            Console.WriteLine("The Multiply method multiply variables a and b without using the multiply operator:");
            Console.WriteLine("a = {0}, b = {1}, a * b = {2}", a, b, MultiplyVariablesWithoutMultiplyOperator.Multiply(a,b));



            var c = 30;
            var d = 5;
            Console.WriteLine("The Devide method devide variables a and b without using the devision operator:");
            Console.WriteLine("c = {0}, d = {1}, c / d = {2}", c, d, DevideVariablesWithoutDevisionOperator.Devision(c, d));



            Console.WriteLine("The smallest number in the given array is:");
            Console.WriteLine(SmallestNumberFounder.FindSmallestInt(new int[] { 78, 56, -2, 12, 8, -33 }));

            Console.ReadLine();
        }
    }
}
