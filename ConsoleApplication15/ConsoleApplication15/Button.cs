using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Button
    {
        public double number;
        public double price;
        public string description;
        public int numberOf;
        
        public double totalPrice()
        {
            return price * numberOf;
        }
    }
}
