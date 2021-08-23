using System;

namespace exchangeVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The exchangeVar method exchange the value of the variables a and b without defining the third variable.");
            ExchangeVar();


            var a = 5;
            var b = 10;
            Console.WriteLine("The Multiply method multiply variables a and b without using the multiply operator:");
            Console.WriteLine("a = {0}, b = {1}, a * b = {2}", a, b, Multiply(a,b));



            var c = 30;
            var d = 5;
            Console.WriteLine("The Devide method devide variables a and b without using the devision operator:");
            Console.WriteLine("c = {0}, d = {1}, c / d = {2}", c, d, Devision(c, d));



            Console.WriteLine("The smallest number in the given array is:");
            Console.WriteLine(FindSmallestInt(new int[] { 78, 56, -2, 12, 8, -33 }));

            Console.ReadLine();
        }


        static void ExchangeVar()
        {
            var a = 5;
            var b = 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            a = a + b;  //5+10=> a= 15
            Console.WriteLine("a = a + b ---- a = {0}, b = {1}", a, b);

            b = a - b;   //15-10 => b=5
            Console.WriteLine("b = a - b ---- a = {0}, b = {1}", a, b);

            a = a - b;   //15-5=>  a=10
            Console.WriteLine("a = a - b ---- a = {0}, b = {1}", a, b);
        }


        static int Multiply(int a , int b)
        {
            int c = 0;
            while (b > 0)
            {
                c += a;
                b--;
            }

            return c;
        }


        static int Devision(int c, int d)
        {
            int e = 0;
            while(c > 0)
            {
               c = c-d;
               e++;
            }
            return e;
        }

        public static int FindSmallestInt(int[] args)
        {

            var min = args[0];
            foreach (int a in args)
            {
                if (a < min)
                {

                    min = a;
                }

            }
            return min;
        }
    }
}
