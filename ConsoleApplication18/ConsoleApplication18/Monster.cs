using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterDuel
{
    public class Monster
    {
        public double health;
        public int attack;
        public string name;

        public Monster(int health1, int attack1, string name1)
        {
            health = health1;
            attack = attack1;
            name = name1;
        }
        public void loseHealth(Wand wand, int baseDamage, int rangeDamage)
        {
            Random rand1 = new Random();
            int chooser1 = rand1.Next(1, rangeDamage);
            Console.WriteLine("After 3 seconds have elapsed, press the a key and then enter, the closer to 3 seconds, the more damage your spell does");
            var extra = System.Diagnostics.Stopwatch.StartNew();
            double extraTime = 0;
            double bonusDamage = 0;
            double bonusDamage1 = 0;
            double bonusDamage2 = 0;
            if (Console.ReadLine() == "a") { 
            extra.Stop();
                 extraTime = extra.ElapsedMilliseconds;
                 bonusDamage = ((Math.Abs(3000 - extraTime))/1000);
                 bonusDamage1 = 1 / bonusDamage;
                 bonusDamage2 = Math.Round((bonusDamage1 * bonusDamage1));
                Console.WriteLine(extraTime);
                Console.WriteLine(bonusDamage2);

            }
            health -= Convert.ToDouble((wand.xp + chooser1 + baseDamage + bonusDamage2));
        }

        public void attackWand(Wand wand)
        {
            Random rand2 = new Random();
            int chooser2 = rand2.Next(1, 4);
            wand.health -= (this.attack + chooser2);
        }
    }
}



