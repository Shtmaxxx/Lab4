using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Components
{
    class RAM : Product
    {
        private int _amount;

        public RAM(string name, string code, double price, int amount) : 
            base(name, code, price)
        {
            _amount = amount;   
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Memory amount: " + _amount.ToString() + " GB");
        }
    }
}
