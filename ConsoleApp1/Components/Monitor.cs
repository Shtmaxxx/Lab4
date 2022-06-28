using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Components
{
    class Monitor : Product
    {
        private float _size;
        private string _brand;
        private string _resolution;

        public Monitor(string name, string code, double price, float size, string brand, string resolution) : 
            base(name, code, price)
        {
            _size = size;
            _brand = brand; 
            _resolution = resolution;   
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Brand: " + _brand);
            Console.WriteLine("Size: " + _size.ToString() + " inches");
            Console.WriteLine("Resolution: " + _resolution);
        }
    }
}
