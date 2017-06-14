using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {

        public static string AskQuestion(string word)
        {
            Console.WriteLine(word);
            return Console.ReadLine();
        }
        public static void tryExperiment()
        {
            //double num1 = Double.Parse(AskQuestion("Enter your first number"));
            //double num2 = Double.Parse(AskQuestion("Enter your second number"));
            //double divAnswer = 0;

            bool ageInvalid = true;
            int age = 0;
            while (ageInvalid)
            {
                Console.WriteLine("Enter age");
                try
                {
                    ageInvalid = false;
                    // divAnswer = num1 / num2;
                    age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("You are" + age);

                }
                catch (Exception e)
                {
                    ageInvalid = true;
                    Console.WriteLine("You suck at math");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Processing...");
                }
            }
        }

        static void Main(string[] args)

        {
            tryExperiment();



        }
    }
}
