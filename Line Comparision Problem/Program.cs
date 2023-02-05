namespace Line_Comparision_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomw! to Line Comparison Pragram");
            Console.WriteLine("Please enter X1 coordinates");
            var X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y1 coordinates");
            var Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter X2 coordinates");
            var X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Y2 coordinates");
            var Y2 = Convert.ToDouble(Console.ReadLine());

            LineEquationUC1 le = new LineEquationUC1();

            double result = le.Equation(X1,X2,Y1,Y2);

            Console.WriteLine("\nThe length of line is : " + result);
        }
    }
}