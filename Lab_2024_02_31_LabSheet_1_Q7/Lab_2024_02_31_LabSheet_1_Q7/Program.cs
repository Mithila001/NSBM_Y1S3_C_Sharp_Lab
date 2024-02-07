using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_31_LabSheet_1_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRun = true;
            while (programRun)
            {
                Console.WriteLine("================ ATM machine ================");
                Console.WriteLine("1.Check balance \n2.Deposite money \n3.Withdraw money \n4.Exit");
                Console.Write("Enter the operation number:");
                int input = Convert.ToInt32(Console.ReadLine());

                if(input == 1)
                {
                    checkBalance();
                    Console.Write("\n\n");
                }
                else if(input == 2)
                {
                    depositeMoney();
                    Console.Write("\n\n");
                }
                else if(input == 3)
                {
                    withdrawMoney();
                }
                else if(input == 4)
                {
                    programRun = false;
                    Console.WriteLine("Have a Nice Day!!!");
                }
                else
                {
                    Console.WriteLine("Enter Valide input!");
                }
            }
            Console.Write("\n\n");
        }

        private static int accountBalance = 5000;
        public static int AccountBalance { get { return accountBalance; } }

        static void checkBalance ()
        {
            Console.WriteLine("Your Account Balance is: " + AccountBalance);
        }

        static void depositeMoney()
        {
            Console.Write("Enter the Deposite amount: ");
            string userInputStr = Console.ReadLine();
            int userInput;

            if (int.TryParse(userInputStr, out userInput)) 
            {
                accountBalance += userInput;
                Console.WriteLine("Money Deposite Complete! \nNew Account balance is: "+AccountBalance);
            }
            else
            {
                Console.WriteLine("Invalide input!!");
            }

        }
        static void withdrawMoney()
        {
            Console.Write("Enter the withdrawal amount: ");
            string userInputStr = Console.ReadLine();
            int userInput;
            if(int.TryParse(userInputStr,out userInput))
            {
                int roundValue = (int)Math.Round(userInput / 10.0) * 10;
                Console.WriteLine("Withdrawing amount is Rs." + roundValue +"\nPress 'Y' to confirm Press 'N' to Quit");
                
                string yesOrNo = Console.ReadLine();
                if (yesOrNo == "y" || yesOrNo == "Y")
                {
                    accountBalance -= roundValue;
                    Console.WriteLine("Success");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
