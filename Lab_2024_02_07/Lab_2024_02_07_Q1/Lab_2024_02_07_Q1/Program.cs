using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Account number: ");
            int accNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Deposite amount: ");
            int depositeAmount = Convert.ToInt32(Console.ReadLine());

            BankAccount account1 = new BankAccount();

            account1.accountNumber = accNumber;
            account1.accountBalance = depositeAmount;

            Console.WriteLine("Your account number is: " + account1.accountNumber);
            Console.WriteLine("Your account balance is: "+ account1.accountBalance);

        }
    }

    public class BankAccount
    {
        public int accountNumber {  get; set; }
        public int accountBalance { get; set; }
        

    }
}
