using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.properties = "Sci fi";
            book1.author = "Bard";
            book1.title = "How to Sleep";

            Console.WriteLine("Title: "+ book1.title);
            Console.WriteLine("Proterties"+ book1.properties);
            Console.WriteLine("Author: "+book1.author);
        }
    }

    public class Book
    {
        public string properties;
        public string title;
        public string author;
    }
}
