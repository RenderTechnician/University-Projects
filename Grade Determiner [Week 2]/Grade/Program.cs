using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am bot, please enter your grade and I will tell you your grade." + "\n" + "Please enter a number only!");
            string Grader = Console.ReadLine();
            int Gradeint = Convert.ToInt32(Grader);
            string Grades = "illegal";
            string Boundary = "an illegal";

            if (39>= Gradeint)
            {
                Grades = "F";
                Boundary = "0 % - 39 %";
            }
            else if (49 >= Gradeint)
            {
                Grades = "D";
                Boundary = "40 % - 49 %";
            }
           else if (59 >= Gradeint)
            {
                Grades = "C";
                Boundary = "50 % - 59 %";
            }
          else  if (69 >= Gradeint)
            {
                Grades = "B";
                Boundary = "60 % - 69 %";
            }
           else if (100 >= Gradeint && Gradeint >= 60)
            {
                Grades = "A";
                Boundary = "70 % - 100 %";
            }
            else
            {
                Console.WriteLine("You have input an illegal value, please close this application and add a legal value");
                Console.ReadLine();
            }
            Console.WriteLine("You achieved a "+ Grades + " grade" + "\n" + "The boundary for this grade is " + Boundary + "\n" + "Press any button to exit");
            Console.ReadLine();
        }
    }
}
//credit
//https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int 
