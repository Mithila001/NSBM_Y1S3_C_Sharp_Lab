using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_01_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate the area of a Rectangle");
            FindTheArea();



        }

        public static void FindTheArea()
        {
            Console.Write("Height: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area of a Rectangle: " + height * width);

        }
    }
}
