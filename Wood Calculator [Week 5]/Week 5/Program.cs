using System;

namespace Week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //width
            double Woodwidth, Woodlength , WidthofWood,Heightofwood;
            do
            {
                Console.WriteLine("Please enter the width of your window make sure you enter a value between 0.5 & 3.5");
              WidthofWood = double.Parse(Console.ReadLine());
            }
            while (WidthofWood > 3.5 || 0.5 > WidthofWood);
            Woodwidth = WWCALC(WidthofWood);
            //feet
            double WFooter = Woodwidth * 3.25;        
            //inches
            //height
            do
            {
                Console.WriteLine("Please enter the height of your window make sure you enter a value between 0.5 & 2");
                Heightofwood = double.Parse(Console.ReadLine());
            }
            while (Heightofwood > 2.0 || 0.5 > Heightofwood);

            Woodlength = WLCALC(Heightofwood);
            double Lfooter = Woodlength * 3.25;
            //final foot calculation
            double absolutef = ABSF(WFooter, Lfooter);
            double glass = GLASSER(WidthofWood, Heightofwood);
        }
        static double WWCALC(double WOWD)
        {
            double Cielwidth = Math.Ceiling(WOWD);
            return Cielwidth;
        } 
        static double WLCALC(double LOWD)
        {
            double Ciellength = Math.Ceiling(LOWD);
            return Ciellength;
        }
        static double ABSF(double Wid, double Hih)
        {
            double finalfoot = Wid + Hih + Wid + Hih;
            Console.WriteLine("You will require " + finalfoot + " feet / " + finalfoot*12 + " inches of wood");
            Console.ReadLine();
            return finalfoot;
        }
        static double GLASSER(Double W, Double L)
        {
            double overallglass = W * L;
            Console.WriteLine("You will require " + overallglass + " square meters of glass");
            Console.ReadLine();
            return overallglass;
        }
    }
}
//set height restrictions 
