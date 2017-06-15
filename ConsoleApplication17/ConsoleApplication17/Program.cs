using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17

{
  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Use wasd to move the lion and e to eat the gazelle");
            Lion myLion = new Lion(2,2,"purple");
            Gazelle myGazelle = new Gazelle(1, 4, "Delicious");
            //Console.WriteLine("Lion x?");
            //myLion.location.x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lion y?");
            //double LionYThing = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lion color?");
            //string LionColorThing =  Console.ReadLine();
            myLion.describe();
            myGazelle.describe();
            string input = "";
            while(input != "q")
            {
                input = Console.ReadLine();
                if (input == "w")
                {
                    myLion.walk("u", 1);
                }
                if (input == "a")
                {
                    myLion.walk("l", 1);

                }
                if (input == "s")
                {
                    myLion.walk("d", 1);

                }
                if (input == "d")
                {
                    myLion.walk("r", 1);

                }
                if(input == "z")
                {
                    myLion.sleep();
                }
                if(input == "e")
                {
                    myLion.eat(myGazelle);
                }
                myLion.describe();
                myGazelle.describe();
            }

           

        }
    }
}
