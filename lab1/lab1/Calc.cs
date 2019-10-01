using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public static class Calc
    {
        public static double AddNumbers(double val1, double val2)
        {
            return val1 + val2;
        }

        public static double SubNumbers(double val1, double val2)
        {
            return val1 - val2;
        }

        public static double MultiNumbers(double val1, double val2)
        {
            return val1 * val2;
        }

        public static double DivNumbers(double val1, double val2)
        {
            return val2 == 0 ? 0 : val1 / val2;
        }
    }
}
