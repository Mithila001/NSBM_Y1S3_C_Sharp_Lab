using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_01_31_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rounds:");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                int fibResult = FibNo(i);
                Console.WriteLine("Output: " + fibResult);
            }
         
        }

        static int FibNo(int i)
        {
            if (i <= 1)
            {
                return i;
            }
            else
            {
                return FibNo(i-1)+FibNo(i-2);
            }
        }
    }
}
