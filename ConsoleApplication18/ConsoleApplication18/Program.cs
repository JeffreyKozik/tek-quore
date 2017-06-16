using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterDuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Wand wand;
            int choice = 0;
            Console.WriteLine("Yer a Wizard " + name + "! Welcome to Hogwarts. Today, Harry is taking a sick day, so you have to defend Hogwarts. You will be dueling against multiple enemies and      eventually facing the all-powerful Lord Voldemort. You will be able to use 6 spells today, based on your xp level. You will be able to choose them from the following menu. Good luck, our fate is your hands!");
            while (true)
            {
                Console.WriteLine("\nPlease choose if you would like the default wand(1) or a customized wand(2).");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong choice. Now you have to start over again.");
                }
                if (choice == 1)
                {
                    wand = new Wand();
                    Console.WriteLine("Congratulations now you have a " + wand.length + " inch " + wand.flex + " " + wand.wood + " wand with a " + wand.core + "   core");
                    menu(wand);
                    break;

                }
                else if (choice == 2)
                {
                    Console.Write("Length(9-14 inches): ");
                    double length = Convert.ToDouble(Convert.ToDouble(Console.ReadLine()));
                    Console.Write("Core(Unicorn Hair, Dragon Heartstring, Phoneix Feather: ");
                    string core = Console.ReadLine();
                    Console.Write("Flexibility(Supple, Hard, Unyielding): ");
                    string flex = Console.ReadLine();
                    Console.Write("Wood type(Black Walnut, Beech, English Oak): ");
                    string wood = Console.ReadLine();
                    Console.WriteLine("Congratulations now you have a " + length + " inch " + flex + " " + wood + " wand with a " + core + " core");

                    wand = new Wand(length, core, flex, wood);
                    menu(wand);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong choice. Now you have to start over again.");
                }
            }

        }
        public static void menu(Wand wand)
        {
            Monster threeDog = new Monster(70, 4, "Three Headed Dog");
            Monster basilisk = new Monster(115, 6, "Basilisk");
            Monster merperson = new Monster(80, 6, "Merperson");
            Monster werewolf = new Monster(90, 9, "Werewolf");
            Monster umbridge = new Monster(120, 13, "Dolores Umbridge");
            Monster voldemort = new Monster(150, 14, "Lord Voldemort");
            //Monster threeDog = new Monster(1, 4, "Three Headed Dog");
            //Monster basilisk = new Monster(1, 6, "Basilisk");
            //Monster merperson = new Monster(1, 6, "Merperson");
            //Monster werewolf = new Monster(1, 9, "Werewolf");
            //Monster umbridge = new Monster(1, 13, "Dolores Umbridge");
            //Monster voldemort = new Monster(1, 14, "Lord Voldemort");
            Monster current;
            int counter = 0;
            bool chooser1boolean = false;
            bool chooser2boolean = false;
            bool chooser3boolean = false;
            bool chooser4boolean = false;
            bool chooser5boolean = false;
            bool chooser6boolean = false;



            while (true)
            {
                if (wand.health <= 0)
                {
                    Console.WriteLine("You have died and Hogwarts has fallen. You have failed. Now we need to call      Harry from his sick leave.");
                    break;
                }
                else
                {
                    Random rand = new Random();
                    int chooser = rand.Next(1, 7);
                    if (chooser == 1)
                    {
                        current = threeDog;
                        if (current.health <= 0)
                        {
                            if (counter >= 6)
                            {
                                Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else
                        {
                            duel(wand, current);
                            counter++;
                        }

                    }
                    if (chooser == 2)
                    {
                        current = basilisk;
                        if (current.health <= 0)
                        {
                            if (counter >= 6)
                            {
                                Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            duel(wand, current);
                            counter++;
                        }
                    }
                    if (chooser == 3)
                    {
                        current = merperson;
                        if (current.health <= 0)
                        {

                            if (counter >= 6)
                            {
                                Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            duel(wand, current);
                            counter++;
                        }
                    }
                    if (chooser == 4)
                    {
                        current = werewolf;
                        if (current.health <= 0)
                        {

                            if (counter >= 6)
                            {
                                Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            duel(wand, current);
                            counter++;
                        }
                    }
                    if (chooser == 5)
                    {
                        current = umbridge;
                        if (current.health <= 0)
                        {

                            if (counter >= 6)
                            {
                                Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            duel(wand, current);
                            counter++;
                        }
                    }
                    if (chooser == 6)
                    {
                        current = voldemort;
                        if (current.health <= 0)
                        {

                            if (counter >= 6)
                            {
                                Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else
                        {
                            duel(wand, current);
                            counter++;
                        }
                    }
                }


            }


        }

        public static void duel(Wand wand, Monster monst)
        {
            int answer;
            int counter = 0;
            while (wand.health > 0)
            {
                answer = 0;
                if (wand.xp >= 0 && wand.xp < 10)
                {
                    Console.WriteLine("\nThis is your current monster: " + monst.name);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    Console.WriteLine("Choose a spell: ");
                    Console.WriteLine("                1.Expelliarmus");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                }
                else if (wand.xp >= 10 && wand.xp < 20)
                {
                    Console.WriteLine("\nThis is your current monster: " + monst.name);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    Console.WriteLine("Choose a spell: ");
                    Console.WriteLine("                1.Expelliarmus");
                    Console.WriteLine("                2.Stupefy");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                }
                else if (wand.xp >= 20 && wand.xp < 30)
                {
                    Console.WriteLine("\nThis is your current monster: " + monst.name);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    Console.WriteLine("Choose a spell: ");
                    Console.WriteLine("                1.Expelliarmus");
                    Console.WriteLine("                2.Stupefy");
                    Console.WriteLine("                3.Incendio");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                }
                else if (wand.xp >= 30 && wand.xp < 40)
                {
                    Console.WriteLine("\nThis is your current monster: " + monst.name);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    Console.WriteLine("Choose a spell: ");
                    Console.WriteLine("                1.Expelliarmus");
                    Console.WriteLine("                2.Stupefy");
                    Console.WriteLine("                3.Incendio");
                    Console.WriteLine("                4.Sectumsempra");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                }
                else if (wand.xp >= 40 && wand.xp < 50)
                {
                    Console.WriteLine("\nThis is your current monster: " + monst.name);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    Console.WriteLine("Choose a spell: ");
                    Console.WriteLine("                1.Expelliarmus");
                    Console.WriteLine("                2.Stupefy");
                    Console.WriteLine("                3.Incendio");
                    Console.WriteLine("                4.Sectumsempra");
                    Console.WriteLine("                5.Crucio");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                }

                else if (wand.xp >= 50)
                {
                    Console.WriteLine("\nThis is your current monster: " + monst.name);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    Console.WriteLine("Choose a spell: ");
                    Console.WriteLine("                1.Expelliarmus");
                    Console.WriteLine("                2.Stupefy");
                    Console.WriteLine("                3.Incendio");
                    Console.WriteLine("                4.Sectumsempra");
                    Console.WriteLine("                5.Crucio");
                    Console.WriteLine("                6.Avada Kedevra");
                    try
                    {
                        answer = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter a valid option");
                    }
                }

                if (answer == 1)
                {
                    wand.expelliarmus(monst);
                    monst.attackWand(wand);
                    if (monst.health <= 0)
                    {
                        wand.health = 100;
                        wand.xp += 5;

                        return;
                    }
                }
                else if (answer == 2)
                {
                    wand.stupefy(monst);
                    monst.attackWand(wand);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    if (monst.health <= 0)
                    {
                        wand.health = 100;
                        wand.xp += 5;
                        //counter++;
                        //if (counter >= 6)
                        //{
                        //    Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                        //    break;
                        //}
                        return;
                    }
                }
                else if (answer == 3)
                {
                    wand.incendio(monst);
                    monst.attackWand(wand);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    if (monst.health <= 0)
                    {
                        wand.health = 100;
                        wand.xp += 5;
                        //counter++;
                        //if (counter >= 6)
                        //{
                        //    Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                        //    break;
                        //}
                        return;
                    }
                }
                else if (answer == 4)
                {
                    wand.sectumsempra(monst);
                    monst.attackWand(wand);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    if (monst.health <= 0)
                    {
                        wand.health = 100;
                        wand.xp += 5;
                        //counter++;
                        //if (counter >= 6)
                        //{
                        //    Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                        //    break;
                        //}
                        return;
                    }
                }
                else if (answer == 5)
                {
                    wand.crucio(monst);
                    monst.attackWand(wand);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    if (monst.health <= 0)
                    {
                        wand.health = 100;
                        wand.xp += 5;
                        //counter++;
                        //if (counter >= 6)
                        //{
                        //    Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                        //    break;
                        //}
                        return;
                    }
                }
                else if (answer == 6)
                {
                    wand.avadaKedara(monst);
                    monst.attackWand(wand);
                    Console.WriteLine("You have " + wand.health + " health left");
                    Console.WriteLine("You have " + wand.xp + " xp");
                    Console.WriteLine(monst.name + " has " + monst.health + " left.");
                    if (monst.health <= 0)
                    {
                        wand.health = 100;
                        wand.xp += 5;
                        //counter++;
                        //if (counter >= 6)
                        //{
                        //    Console.WriteLine("You won, congrats!!! Harry is forever grateful to you and will pay you a hefty sum.");
                        //    break;
                        //}
                        return;
                    }
                }


            }
        }
    }
}



