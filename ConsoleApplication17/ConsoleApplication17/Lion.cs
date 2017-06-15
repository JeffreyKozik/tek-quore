using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    public class Lion : Animal
    {
        public Lion()
        {
            myLocation = new Location();
            myLocation.x = 1;
            myLocation.y = 2;
            Color = "purple";

        }
       public void describe()
        {
            Console.WriteLine("The " + this.Color + " lion is at " + this.myLocation.x + " , " + this.myLocation.y);

        }
        public void eat(Gazelle lunch)
        {
            if((this.myLocation.x  == lunch.myLocation.x) && (this.myLocation.y == lunch.myLocation.y))
            {
                Console.WriteLine("Yum");
            }
            else
            {
                Console.WriteLine("Try harder");
            }
        }
        public Lion(int startX, int startY, string startColor)
        {
            myLocation = new Location();
            myLocation.x = startX;
            myLocation.y = startY;
            Color = startColor;

        }
    }
}
