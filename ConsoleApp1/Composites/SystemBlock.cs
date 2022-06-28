using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Composites
{
    class SystemBlock : Product
    {
        private List<Product> _products = new List<Product>();

        public SystemBlock(string name, string code, double price) : 
            base(name, code, price) 
        {

        }

        public override void Add(Product product)
        {
            _products.Add(product);
            Price += product.Price;
        }

        public override void Remove(Product product)
        {
            _products.Remove(product);
            Price -= product.Price;
        }

        private double CalculatePrice(double price)
        {
            return price += price * 0.15;
        }

        public override void Print()
        {
            var price = CalculatePrice(Price);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Vendor Code: " + VendorCode);
            Console.WriteLine("Price: " + price + "$");
            Console.WriteLine("Price of components: " + Price + "$ \n");
            Console.WriteLine("Components: ");
            foreach (var product in _products)
            {
                product.Print();
                Console.WriteLine();
            }
        }
    }
}
