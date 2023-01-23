using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblems
{
    public class Program
    {
        public void Compare(double l1, double l2)
        {
            int result = l1.CompareTo(l2);
            if (result > 0)
                Console.WriteLine("line1 is greater than line2");
            else if (result < 0)
                Console.WriteLine("line1 is smaller than line2");
            else
                Console.WriteLine("Both the lines are equal");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Computation Problem");

            //Input for Line1
            Console.WriteLine("Enter value for line1");
            Console.WriteLine("Enter the value of x1 , y1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2 , y2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            double length1 = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine("Length of line1 is : "+ length1);
            //Input for Line2
            Console.WriteLine("Enter value for line2");
            Console.WriteLine("Enter the values of x3,y3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x4 ,y4:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            double length2 = Math.Sqrt((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            Console.WriteLine("Length of line2 is: "+ length2);
            Program p = new Program();
            p.Compare(length1, length2);
            Console.ReadLine();
        }
    }
}
