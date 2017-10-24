using System;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrTemp,celTemp;
            Console.WriteLine
            ("Enter a temperature in degrees Fahrenheit");
            fahrTemp = double.Parse(Console.ReadLine());
            celTemp = calcTempC(fahrTemp);

            displayTempC(celTemp);
        }
     static double calcTempC(double faren)
        {
            double C = (faren - 32) * 5 / 9;
            return C;
        }
        static double displayTempC(double Celler)
        {
            Console.WriteLine(Celler);
            Console.ReadLine();
            return Celler;
            
        }
    }
}
