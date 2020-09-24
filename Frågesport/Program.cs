using System;

namespace Frågesport
{
    class Program
    {
        static public int qn;
        static void Main(string[] args)
        {
            Program.qn = 1;
            int points = 0;
            Console.WriteLine("Eeeehm, så det är frågesport");
            
            
        }
    }
    class Questions
    {
        public Questions(int numbertmp, string questiontmp, string answer1tmp, string answer2tmp, string answer3tmp, string answer4tmp, string correcttmp)
        {
            int number = numbertmp;
            string question = questiontmp;
            string answer1 = answer1tmp;
            string answer2 = answer2tmp;
            string answer3 = answer3tmp;
            string answer4 = answer4tmp;
            string correct = correcttmp;

            while (Program.qn == number)
                {
                Console.WriteLine("Question " + number + ": " + question);
                Console.WriteLine("A: " + answer1 + " B: " + answer2 + " C: " + answer3 + " D: " + answer4);
                


            }


        }


    }
}
