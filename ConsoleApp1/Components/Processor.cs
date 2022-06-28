using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Components
{
    class Processor : Product
    {
        private string _brand;
        private double _clockRate;
        private int _cores;

        public Processor(string name, string code, double price, string brand, double clockRate, int cores) : 
            base(name, code, price)
        {
            _brand = brand;
            _clockRate = clockRate; 
            _cores = cores;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Brand: " + _brand);
            Console.WriteLine("Clock rate: " + _clockRate + " GHz");
            Console.WriteLine("Cores amount: " + _cores.ToString());
        }
    }
}
