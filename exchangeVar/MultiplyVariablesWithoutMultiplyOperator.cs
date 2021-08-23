using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeVar
{
    public class MultiplyVariablesWithoutMultiplyOperator
    {
        public static int Multiply(int a, int b)
        {
            int c = 0;
            while (b > 0)
            {
                c += a;
                b--;
            }

            return c;
        }
    }
}
