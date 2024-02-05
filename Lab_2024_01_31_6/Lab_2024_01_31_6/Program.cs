using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_01_31_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your makr: ");
            int marks = int.Parse(Console.ReadLine());

            if (marks < 40)
            {
                Console.WriteLine("");
            }
            else if (marks < 50)
            {
                Console.WriteLine("");
            }
            else if(marks < 60)
            {
                Console.WriteLine("");
            }
            else if(marks < 75)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
