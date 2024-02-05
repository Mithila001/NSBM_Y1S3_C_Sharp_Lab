using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_01_2024_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int tot = 0;
            if (num > 0)
            {
                for (int i = num; i > 0; i--)
                {
                    tot = tot + i;
                  

                }
                Console.WriteLine("Answer:" + tot);
            }
            else
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}
