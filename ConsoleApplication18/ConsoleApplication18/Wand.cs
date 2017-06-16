using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterDuel
{
    public class Wand
    {
        public double length;
        public string core;
        public string flex;
        public string wood;
        public int xp;
        public int health;
        public Wand()
        {
            length = 11.0;
            core = "Unicorn Hair";
            flex = "Supple";
            wood = "Black Walnut";
            xp = 5;
            health = 100;
        }

        public Wand(double length1, string core1, string flex1, string wood1)
        {
            length = length1; //9-14
            core = core1; //dragon heartstring, unicorn hair, phoneix feather
            flex = flex1;//idc
            wood = wood1;//pick a tree
            xp = 5;
            health = 100;
        }

        public void expelliarmus(Monster monst)
        {
            monst.loseHealth(this, 1, 2, 2);
        }

        public void stupefy(Monster monst)
        {
            if (xp >= 10)
            {
                monst.loseHealth(this, 1, 3, 5);
            }
            else
            {
                Console.WriteLine("You don't have enough xp. Need 10");
            }
        }

        public void incendio(Monster monst)
        {
            if (xp >= 20)
            {
                monst.loseHealth(this, 4, 3, 2);
            }
            else
            {
                Console.WriteLine("You don't have enough xp. Need 20");
            }
        }
        public void sectumsempra(Monster monst)
        {
            if (xp >= 30)
            {
                monst.loseHealth(this, 1, 10,2);
            }
            else
            {
                Console.WriteLine("You don't have enough xp. Need 30.");
            }
        }

        public void crucio(Monster monst)
        {
            if (xp >= 40)
            {
                monst.loseHealth(this, 2, 10,2);
            }
            else
            {
                Console.WriteLine("You don't have enough xp. Need 40.");
            }
        }

        public void avadaKedara(Monster monst)
        {
            if (xp >= 50)
            {
                monst.loseHealth(this, 5, 10,2);
            }
            else
            {
                Console.WriteLine("You don't have enough xp. Need 50.");
            }

        }
    }
}



