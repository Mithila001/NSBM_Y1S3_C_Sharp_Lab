using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemprestureTraker tempWeek1 = new TemprestureTraker();
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter the week {i+1} temperature: ");
                tempWeek1.dailyTemp[i] = int.Parse(Console.ReadLine());
            }
           
            Console.Write("Week temperature\n");

            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine($"Day {j + 1}: {tempWeek1.dailyTemp[j]}");
            }

        }
    }

    public class TemprestureTraker
    {
        public int[] dailyTemp = new int[7]; 

    }
}
