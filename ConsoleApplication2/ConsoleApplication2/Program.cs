using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);

            return Console.ReadLine();

        }
        public static void campCounseling()
        {
            double waterTemperature;
            waterTemperature = Convert.ToDouble(AskQuestion("What is the water temperature in degrees Fahrenheit?"));
            double airTemperature;
            airTemperature = Convert.ToDouble(AskQuestion("What is the air temperature in degrees Fahrenheit?"));
            double rainProbability;
            rainProbability = Convert.ToDouble(AskQuestion("What is the probability of rain by percentages?"));
            double timeDay;
            timeDay = Convert.ToDouble(AskQuestion("What is the time of day in military time?"));
            string soccerStatement = "Go play soccer and break your ankles, cause crickets a better sport";
            if (((timeDay >= 1200) && (timeDay <= 1600)) && (waterTemperature > 70) && (airTemperature > 80) && (rainProbability < 30))
            {

                Console.WriteLine("Go take your kids swimming in a hole with flesh eating pirannhas then you wont have to worry about them anymore");
                Console.WriteLine(soccerStatement);
            }
            else if ((airTemperature > 60) && (rainProbability < 50) && ((timeDay >= 1000) && (timeDay <= 1800)))
            {
                Console.WriteLine(soccerStatement);
            }

            else if (timeDay > 2000)
            {
                if ((rainProbability > 60) || (timeDay > 1800))
                {
                    Console.WriteLine("Go play Monopoly an be the greedy capitalistic pigs that you truly are");
                }
                else
                {
                    Console.WriteLine("Go watch Star Wars cause thats obviously the best movie series ever");
                }
            }
            else
            {
                Console.WriteLine("Go cry your puny little souls in a corner cause you can't do anything today");
            }
            //Take students swimming if the following conditions are met: Time of day is between

            //12pm to 4pm, water temp is above 70 and air temp is above 80.Also, the probability of

            //rain in the forecast should be below 30 %

            //● Play soccer if the temperature is above 60 and the probability of rain is below 50 %.Also

            //the event can happen between 10am to 6pm.

            //● Play board games if the probability of rain is above 60% or the time is past 6pm.

            //● Watch Movies if the time is past 8pm.
        }
        public static void methodPractice1()
        {
            double temperature;
            temperature = Convert.ToDouble(AskQuestion("What is the temperature outside in degrees F"));
            string waterCondition;
            waterCondition = AskQuestion("Is the water cold in the pool? (y/n)");
            string precipCondition;
            precipCondition = AskQuestion("Is it raining out? (y/n)");

            if (temperature > 80)
            {
                if (waterCondition == "y")
                {
                    Console.WriteLine("Go swimming ");
                }
                else if (waterCondition == "n")
                {
                    Console.WriteLine("Go swimming, and die of pneumonia");
                }
            }
            else
            {
                if (waterCondition == "y")
                {
                    Console.WriteLine("Go in your jacuzzi your rich bastard");

                }
                else if (waterCondition == "n")
                {
                    Console.WriteLine("Go back to sleep");
                }
            }




        }

        public static void runTracker()
        {
            double averageMile = 0.0;
            double totalMiles = 0.0;
            double totalMinutes = 0.0;
            while (true)
            {
                Console.WriteLine("How far did you run in miles?");
                double distanceRun = Double.Parse(Console.ReadLine());
                Console.WriteLine("How long did it take you in minutes?");
                double timeRun = Double.Parse(Console.ReadLine());
                totalMiles += distanceRun;
                totalMinutes += timeRun;
                double averagePerMile = Math.Round((timeRun / distanceRun), 1);
                Console.WriteLine("It took you " + averagePerMile + " minutes per mile");
                if (averageMile == 0.0)
                {
                    Console.WriteLine("This is your first run, you lazy fool");
                }
                else
                {
                    if (averagePerMile < averageMile)
                    {
                        Console.WriteLine("Wow congratulations you actually improved at something in life");

                    }
                    else if (averagePerMile > averageMile)
                    {
                        Console.WriteLine("Just quit now, give up, life isn't worth it anymore");
                    }
                    else if (averagePerMile == averageMile)
                    {
                        Console.WriteLine("Uh-oh youre freakishly consistent, youre probably a robot, this computer is probably getting hacked right now- implement self destruct mode");
                    }
                }
                averageMile = totalMinutes / totalMiles;
                Console.WriteLine("Your total average time is " + averageMile + " minutes per mile");
                Console.WriteLine("Would you like to do another? (y/n)");
                string userOption = Console.ReadLine();
                if (userOption == "n")
                {
                    break;
                }

            }


        }

        static void Main(string[] args)
        {
            //  runTracker();
            // methodPractice1();
            campCounseling();

        }
    }
}
