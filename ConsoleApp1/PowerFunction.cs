using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSamples
{
    class PowerFunction
    {
        internal long ImplementPower(int element, int powernumber)
        {
            long temp = element;
            for (int i = 1;i<powernumber;i++)
            {
                temp = temp * element;
            }
            return temp;

        }
        internal double ImplementPower(double element, double powernumber)
        {
            return Math.Pow(element, powernumber);
        }
        internal double ImplementPower1(double element, double powernumber)
        {
            if (powernumber > 1)
                return element * ImplementPower1(element, powernumber - 1);
            else
                return element;
        }
    }
}
