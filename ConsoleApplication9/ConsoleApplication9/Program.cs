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
            
            while (ageInvalid)
            {
                Console.WriteLine("Enter age");
                int age = 0;
                try
                {
                    ageInvalid = false;
                    // divAnswer = num1 / num2;
                    age = Convert.ToInt16(Console.ReadLine());


                }
                catch (Exception e)
                {
                    ageInvalid = true;
                    Console.WriteLine("You suck at math");
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Main(string[] args)

        {
            tryExperiment();

         

        }
    }
}
