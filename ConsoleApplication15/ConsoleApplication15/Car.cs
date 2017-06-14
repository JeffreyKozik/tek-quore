using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Car
    {
        public string make;
        public string model;
        string color;
        int year;
        float MSRP;
        int VIN;
        public float sellCar(string person, float salesPrice)
        {
            return this.MSRP / salesPrice * 1000;
        }
    }
}
