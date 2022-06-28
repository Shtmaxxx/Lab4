using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Composites
{
    class Computer : Product
    {
        private List<Product> _products = new List<Product>();

        public Computer(string name, string code, double price) :
            base(name, code, price)
        {

        }

        public override void Add(Product product)
        {
            _products.Add(product);
            Price += product.Price;
        }

        private double CalculatePrice(double price)
        {
            return price += price * 0.05;
        }

        public override void Print()
        {
            var price = CalculatePrice(Price);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("VendorCode: " + VendorCode);
            Console.WriteLine("Price: " + price + "$ \n");
            Console.WriteLine("Components: ");
            foreach (var product in _products)
            {
                product.Print();
                Console.WriteLine();
            }
        }
    }
}
