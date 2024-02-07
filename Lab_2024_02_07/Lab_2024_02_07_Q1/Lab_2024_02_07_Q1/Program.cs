using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2024_02_07_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product("Car",30000000);

           Console.WriteLine(product.ProductName +" Rs."+ product.Price);
           

        }
    }

    public class Product
    {
        public string ProductName;
        public int Price;

        public Product(string productName, int price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
