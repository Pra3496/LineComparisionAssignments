using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_Problem
{
    internal class LineEquationUC3
    {

        public short EquationCmp(double X1, double X2, double X3, double X4, double Y1, double Y2, double Y3, double Y4)
        {
            double temp1 = Math.Pow((X2 - X1), 2);
            double temp2 = Math.Pow((Y2 - Y1), 2);
            double Length1 = Math.Sqrt(temp1 + temp2);
            Console.WriteLine("\nLength of line1: " + Length1);

            double temp3 = Math.Pow((X4 - X3), 2);
            double temp4 = Math.Pow((Y4 - Y3), 2);
            double Length2 = Math.Sqrt(temp3 + temp4);
            Console.WriteLine("\nLength of line2: " + Length2);

            if (Length1.Equals(Length2))
            {
                return 1;
            }
            else if (Length1 > Length2)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
