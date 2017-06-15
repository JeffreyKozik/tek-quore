using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    public class Animal
    {
       public Double Anger;
       public Double Age;
       public Double Size;
       public String Color;
      public  Location myLocation;
        //public Animal(double angerName, double ageName, double sizeName, string colorName, Location myLocationName)
        //{
        //    Anger = angerName;
        //    Age = ageName;
        //    Size = sizeName;
        //    Color = colorName;
            
        //}
        public void sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ");
        }
        public void walk(string direction, int speed)
        {
            //u for up, d for down, l for left, r for right
            if(direction == "u")
            {
                this.myLocation.y += speed;
            }
            if (direction == "d")
            {
                this.myLocation.y -= speed;
            }
            if (direction == "l")
            {
                this.myLocation.x -= speed;
            }
            if (direction == "r")
            {
                this.myLocation.x += speed;
            }
         
            
           
            
        }

    }
}
