using System;

namespace Week_7_attempt_2
{
    class CountryTest
    {
        public static void Main(string[] args)
        {
            Country C1 = new Country("The United Kingdom", 59000000, 245000.0);
            Country C2 = new Country("China", 1330000000, 9600000.0);
            Country C3 = new Country("Malawi", 500000, 118000.0);
            Console.WriteLine(C1.place + " has a population of " + C1.population + " people, the surface area of " + C1.place + " is " + C1.Area + " KM Squared");
            Console.WriteLine(C2.place + " has a population of " + C2.population + " people, the surface area of " + C2.place + " is " + C2.Area + " KM Squared");
            Console.WriteLine(C3.place + " has a population of " + C3.population + " people, the surface area of " + C3.place + " is " + C3.Area + " KM Squared");
            Console.ReadLine();
        }
    }
    class Country
    {
       public string place;
       public int population;
       public double Area;
       
        public Country(string input, int people, double Surface)
        {
            place = input;
            population = people;
            Area = Surface;
        }
    }
}
