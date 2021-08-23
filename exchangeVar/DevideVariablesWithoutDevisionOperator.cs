using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeVar
{
    public class DevideVariablesWithoutDevisionOperator
    {
        public static int Devision(int c, int d)
        {
            int e = 0;
            while (c > 0)
            {
                c = c - d;
                e++;
            }
            return e;
        }
    }
}
