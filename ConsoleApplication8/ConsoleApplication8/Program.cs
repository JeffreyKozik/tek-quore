using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        public static void testFunction()
        {
            List<string> studentList = new List<string>();
           

            foreach (string student in studentList)
            {
                Console.WriteLine(student);

            }

            bool people = true;
            while (people)
            {
                string studentName = AskQuestion("What's your name");
                double studentScore = Convert.ToDouble(AskQuestion("What's your score"));
                string anotherOne = AskQuestion("Another one? (y/n)");
              

            }
        }
        public static string didPass(double score)
        {
            if (score >= 70)
            {
                return "passed";
            }
            else
            {
                return "failed";
            }
        }

        public static void testFunctionNew()
        {
            List<string> studentTotalThing = new List<string>();
            while (true)
            {
             
               
                string studentFirstName = AskQuestion("What's your first name");
                string studentLastName = AskQuestion("What's your last name");
                double studentTestScore = Convert.ToDouble(AskQuestion("What's your score"));
                string studentCondition = didPass(studentTestScore);
                studentTotalThing.Add(studentFirstName + " " + studentLastName + " " + studentCondition);
                foreach(string student in studentTotalThing)
                {
                    Console.WriteLine(student);
                }
                string anotherOne = AskQuestion("Another one? (y/n)");
                if (anotherOne == "n")
                {
                    break;
                }


            }
        }
        static void Main(string[] args)
        {
            testFunctionNew();
        }
    }
}