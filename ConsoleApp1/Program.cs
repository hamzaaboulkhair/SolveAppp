using System;

namespace SolveApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coefficients a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            var solution = SolveQuadratic(a, b, c);

            
            
                Console.WriteLine($"Roots: X1={solution.X1}, X2={solution.X2}");
            }


       public static Solution SolveQuadratic(double a, double b, double c)
{
    double discriminant = b * b - 4 * a * c;

    if (discriminant > 0)
    {
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        return new Solution(x1, x2);  // Deux racines réelles
    }
    else if (discriminant == 0)
    {
        double x1 = -b / (2 * a);
        return new Solution(x1, null);  // Une seule racine réelle
    }
    else
    {
        return new Solution(null, null);  // Pas de racines réelles
    }
}

    }
}
