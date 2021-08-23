using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeVar
{
    public class SmallestNumberFounder
    {
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
