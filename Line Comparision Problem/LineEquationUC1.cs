using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision_Problem
{
    internal class LineEquationUC1
    {

        public double Equation(double X1, double X2, double Y1, double Y2)
        {
            double temp1 = Math.Pow((X2 - X1), 2);
            double temp2 = Math.Pow((Y2 - Y1), 2);
            return Math.Sqrt(temp1 + temp2);

        }
        


    }
}
