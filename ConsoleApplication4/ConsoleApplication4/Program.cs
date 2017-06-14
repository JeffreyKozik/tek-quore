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
            studentList.Add("John");
            studentList.Add("Thomas");
            studentList.Add("Joseph");
            studentList.Add("Parker");
            studentList.Add("Jacob");

            foreach (string student in studentList)
            {
                Console.WriteLine(student);

            }

            bool people = true;
            while (people) {
                string studentName = AskQuestion("What's your name");
                double studentScore = Convert.ToDouble(AskQuestion("What's your score"));
                string anotherOne = AskQuestion("Another one? (y/n)");
                // if(string == )

            } }
            public static string didPass(double score)
        {
            if(score >= 70)
            {
                return "pass";
            }
            else
            {
                return "fail";
            }
        }

        public static void testFunctionNew()
        {
            bool people = true;
            while (people)
            {
                List<string> studentFirstList = new List<string>();
                List<string> studentLastList = new List<string>();
                List<double> studentTestScoreList = new List<double>();
                string studentFirstName = AskQuestion("What's your first name");
                string studentLastName = AskQuestion("What's your last name");
                double studentTestScore = Convert.ToDouble(AskQuestion("What's your score"));
                studentFirstList.Add(studentFirstName);
                studentLastList.Add(studentLastName);
                studentTestScoreList.Add(studentTestScore);
                Console.WriteLine(studentFirstList[1]);
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
