using System;

namespace getandset
{
    class Module
    {
       static private int Coursework;
       static private int Exam;
       static private double examweighting;

        public Module()
        {

        }
        public Module(int cw, int ex, double exwt)
        {
            cw = 0;
            ex = 0;
            exwt = 0.0;
        }

        public int GetCW()
        {
           return Coursework;
        }
        public int GetEx()
        {
            return Exam;
        }
        public double Exwt()
        {
            return examweighting;
        }
        public void setData(int cw, int ex, double exwt)
        {
            Random rand = new Random();
            Coursework = rand.Next(1, 100);
            Exam = rand.Next(1, 100);
            examweighting = (rand.Next(30, 100));
        }
    }
    class TestProgram
    {
        static void Main(string[] args)
        {
            Module english = new Module(0,0,0.0);
            Module Chemistry = new Module(57,26,22.0);

            Console.WriteLine("Your mark for Chemistry is " + FinalMark(Chemistry) + " %" + "\n" + "_________________________________" 
                + "\n" + "Your coursework mark was " + Chemistry.GetCW() + " %" +  "\n" + "Your Exam mark was " + Chemistry.GetEx() + " %" + "\n" + "The exam weighting was " + Chemistry.Exwt() + " %" + "\n" + "\n" + "\n" + "\n" + "\n" );
           

            Console.WriteLine("Your mark for English is " + FinalMark(english) + " %" + "\n" + "_________________________________" 
                + "\n" + "Your coursework mark was " + english.GetCW() + " %" +  "\n" + "Your Exam mark was " + english.GetEx() + " %" + "\n" + "The exam weighting was " + english.Exwt() + " %");
            Console.ReadLine();
        }
        static public int FinalMark(Module subject)
        {
           
          subject.setData(0, 0, 0.0);
            int x = subject.GetCW();
            int y = subject.GetEx();
            double z = subject.Exwt();
            int final = Convert.ToInt32((x * (100 - z)) + ((y * z) )) / 100;
            
            return final;
        }
    }
}
