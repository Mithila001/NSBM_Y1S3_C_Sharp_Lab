using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_01_31_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int multi = 1;

            for (int i = num; 0 < i; i--)
            {
               
                Console.WriteLine("{0}*{1} = {2}",num,multi, num*multi);
                multi++;
            }
        }
    }
}
