using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
  public  class Gazelle : Animal
    {
        public Gazelle()
        {
            myLocation = new Location();
            myLocation.x = 1;
            myLocation.y = 2;
            Color = "purple";

        }
        public void describe()
        {
            Console.WriteLine("The " + this.Color + " gazelle is at " + this.myLocation.x + " , " + this.myLocation.y);

        }
        public Gazelle(int startX, int startY, string startColor)
        {
            myLocation = new Location();
            myLocation.x = startX;
            myLocation.y = startY;
            Color = startColor;

        }
    }
}
