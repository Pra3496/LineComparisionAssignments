﻿using System.Diagnostics.SymbolStore;

namespace Line_Comparision_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\nWelcome! to Line Comparison Pragram\n");

            Console.Write("\nFirst Line\n");
            Console.Write("\nPlease enter X1 coordinates : ");
            var X1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease enter Y1 coordinates : ");
            var Y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nPlease enter X2 coordinates : ");
            var X2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease enter Y2 coordinates : ");
            var Y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\nSecond Line\n");
            Console.Write("\nPlease enter X3 coordinates : ");
            var X3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease enter Y3 coordinates : ");
            var Y3 = Convert.ToDouble(Console.ReadLine());


            Console.Write("\nPlease enter X4 coordinates : ");
            var X4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease enter Y4 coordinates : ");
            var Y4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n");

            LineEquationUC2 le = new LineEquationUC2();

            bool chk = le.EquationCmp(X1,X2,X3,X4,Y1,Y2,Y3,Y4);

            if (chk == true)
            {
                Console.WriteLine("\n\n\tLines are equal\n");
            }
            else
            {
                Console.WriteLine("\n\n\tLines are not equal\n");
            }



        }
    }
}