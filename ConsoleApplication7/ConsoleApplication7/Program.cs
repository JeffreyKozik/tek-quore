using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        public static string AskQuestion(string word)
        {
            Console.WriteLine(word);
            return Console.ReadLine();
        }
        static void Main(string[] args)

        {
            double yearsExperience = Convert.ToDouble(AskQuestion("How many years experience do you have?"));
            string degreeAcquired = AskQuestion("What degree did you acquire?");

            double onlineExamScore = Convert.ToDouble(AskQuestion("What was your exam score"));



        }
    }
}
