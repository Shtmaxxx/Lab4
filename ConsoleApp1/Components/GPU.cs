using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Components
{
    class GPU : Product
    {
        private string _brand;
        private int _videoMemoryAmount;

        public GPU(string name, string code, double price, string brand, int memory) : 
            base(name, code, price)
        {
            _brand = brand;
            _videoMemoryAmount = memory;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Brand: " + _brand);
            Console.WriteLine("Video memory amount: " + _videoMemoryAmount.ToString() + " GB");
        }
    }
}
