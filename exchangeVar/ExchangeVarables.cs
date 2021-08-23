using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeVar
{
    public class ExchangeVarables
    {
        public static void ExchangeVar()
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
    }
}
