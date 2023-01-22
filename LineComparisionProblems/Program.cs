using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Computation Problem");

            Console.WriteLine("Enter the value of x1 , y1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 , y2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of line is :"+ length);
            Console.ReadLine();

        }
    }
}
