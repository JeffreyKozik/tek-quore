using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterDuel
{
    public class Monster
    {
        public int health;
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
            health = health - (wand.xp + chooser1 + baseDamage);
        }

        public void attackWand(Wand wand)
        {
            Random rand2 = new Random();
            int chooser2 = rand2.Next(1, 4);
            wand.health -= (this.attack + chooser2);
        }
    }
}



