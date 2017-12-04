using System;

namespace joke_teller
{
    class Program
    {
        int JokeCount;
        static string[] Joke1 = new string[4] {
            "Your life.",
            "The current housing economy. Seriosly £150K for a fucking bungallo.",
            "Undergraduate tuition fees.",
            "How many times Skaro was destroyed, seriously it got to be at least 5 by now." };
        static void Main(string[] args)
        {
            //sets random to a new random
            Random JkRadom = new Random();
            //sets the value to less than the declared value
            JkRadom.Next(2);
            string Jokes;
            Console.WriteLine("Please type 'computer, tell me a joke' and i'll pull a joke from my incredible silicone brain!!");
            Jokes = Console.ReadLine();
        

            if (Jokes == "computer, tell me a joke")
            {
                //Writes the array to the console, the length is dynamically adjusted
                Console.WriteLine(Joke1[JkRadom.Next(Joke1.Length)].ToString());
              
                Console.ReadLine();
            }
        }
    }
}
