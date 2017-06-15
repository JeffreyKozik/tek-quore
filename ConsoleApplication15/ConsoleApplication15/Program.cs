using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.model = "Fusion";
            //car1.make = "Ford";
            //car1.color = "yellow";
            //Car car2 = new Car();
            //car2.model = "Honda";
            //car2.make = "CRV";
            //car2.color = "Black";
            //Car car3 = new Car();
            //car3.model = "Punch Buggy";
            //car3.make = "Volkswage";
            //car3.color = "Pink";

            //car1.MSRP = 9000f;
            //float commissionCar1 = car1.sellCar("Ani", 8000f);
            //car2.MSRP = 5200f;
            //float commissionCar2 = car2.sellCar("Justin", 4900f);


            //Console.WriteLine("Ani sold a " + car1.make + ", "  + " and received " + commissionCar1 + " for his comission.");
            //Console.WriteLine("Just sold a " + car2.make + ", " + " and received " + commissionCar2 + " for his comission.");
            Button button1 = new Button();
            button1.price = 0.50;
            button1.numberOf = 12;
            double buttonFunc = button1.totalPrice();
            Console.WriteLine(buttonFunc);
        }
    }
}
