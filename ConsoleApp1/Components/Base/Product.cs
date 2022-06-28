using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Product
    {
        protected string Name;
        protected string VendorCode;
        public double Price { get; set; }

        public Product(string name, string vendorCode, double price)
        {
            Name = name;
            VendorCode = vendorCode;
            Price = price;
        }

        public virtual void Add(Product product)
        {

        }

        public virtual void Remove(Product product)
        {

        }

        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Vendor code: " + VendorCode);
            Console.WriteLine("Price: " + Price + "$");
        }
    }
}
