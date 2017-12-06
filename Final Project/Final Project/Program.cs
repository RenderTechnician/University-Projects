using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Final_Project
{
    public class values
    {
        // Variable Declaration
        private string puller = "null";                     //gets string from readline
        private static bool bracket = false;               //A bool that is passed to the object to determine specific conditions. Mainly used when brackets are detected.
        private string Val = "null";                      // Equals the value of the current char of puller
        private string result = "null";                  // This is the postfix expresion 
        private int Progress = 0;                       // Controls how long the char counter is
        private static Stack Stacks = new Stack();
       private static Stack Bracket = new Stack();
        //Get + Set for each variable
        public string GetPuller     
        {
         get { return puller; }
         set { puller = value; }
        }
        public bool GetBracket
        {
            get { return bracket; }
            set { bracket = value; }
        }
        public string GetVal
        {
          get { return Val; }
          set { Val = value; }
        }
        public string GetResult
        {
            get { return result; }
            set{ result = value; }  
        }
        public int GetProgress
        {
            get { return Progress; }
            set { Progress = value;}
        }
        public Stack GetStack
        {
            get { return Stacks; }
            set { Stacks = value; }
        }
        public Stack GetBrack
        {
            get { return Bracket; }
            set { Bracket = value; }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            values val = new values();
            Console.WriteLine("Please enter an infix expression below. I will convert it to a postfix expression using my mechanical mind!");

            val.GetPuller = Console.ReadLine();
            //val.GetProgress = val.GetPuller.Length;
            do
            {
                val.GetVal = val.GetPuller[val.GetProgress].ToString();
                IsOperator(val.GetVal);  
                val.GetProgress++;
            } while (val.GetPuller.Length > val.GetProgress);
                
             while (val.GetProgress == val.GetPuller.Length && val.GetStack.Count > 0)
            {
                Console.Write(val.GetStack.Pop());
            }
            //output debug component
            Console.ReadLine();
        }
        static string IsOperator(string charer)
        {
            values val = new values();
           // Stack Stacks = new Stack();  // The primary stack 
           // Stack Bracket = new Stack();
            Regex r = new Regex("^[a-zA-Z ]+$");
            //appends all operators to stack bracket
            if (charer == "(")
            {
                val.GetBracket = true;
               // Console.WriteLine(val.GetBracket);
            }
            //expels all items stored in bracket stack to the console
            else if (charer == ")")
            {
                if (val.GetBrack != null)
                {
                   Console.Write(val.GetBrack.Pop());
                    val.GetBracket = false;
                }
            }
            //will pop the stack if it isn't null, but the addition value will not be printed (Addition operator)
             if (charer == "+")
            {
              if (val.GetBracket == false)
                {
                    
                    if (val.GetStack.Count != 0)
                    {
                        while(val.GetStack.Count != 0) 
                        {
                            Console.Write(val.GetStack.Pop());
                            val.GetStack.Push(charer);
                            break;
                        }
                    }
                    else
                    {
                        val.GetStack.Push(charer);
                    }
                }
                 if (val.GetBracket == true)
                {
                    val.GetBrack.Push(charer);
                }
            }
            //multiplication operator
            if (charer == "*")
            {
                if (val.GetBracket == false)
                {
                    while (val.GetStack.Count != 0)
                    {
                        if (!val.GetStack.Contains("+"))
                        {
                            Console.Write(val.GetStack.Pop());
                        }
                        break;
                    }
                    val.GetStack.Push(charer);
                }
                if (val.GetBracket == true)
                {
                    val.GetBrack.Push(charer);
                }
            }
            //division operator
            if (charer == "/")
            {
                if (val.GetBracket == false)
                {
                    val.GetStack.Push(charer);
                } 
                if (val.GetBracket == true)
                {
                    val.GetBrack.Push(charer);
                }
            }
            //subtraction operator
            if (charer == "-")
            {
                if (val.GetBracket == false)
                {
                    Console.Write(val.GetStack.Pop());
                    val.GetStack.Push(charer);
                }
                if (val.GetBracket == true)
                {
                    val.GetBrack.Push(charer);
                }
            }
            if (r.IsMatch(charer))
            {
                Console.Write(charer);
            }
         //   Console.WriteLine(val.GetStack.Count);
            //brackets left, brackets right, addition, subtraction, multiplication, division
            return charer;
        }
    }
}
//https://stackoverflow.com/questions/25748906/how-to-check-if-a-stackt-is-empty
//https://msdn.microsoft.com/en-us/library/dy85x1sa(v=vs.110).aspx
//https://msdn.microsoft.com/en-us/library/system.text.regularexpressions.regex(v=vs.110).aspx
//http://www.dotnetbull.com/2013/03/regex-check-if-string-contains-only.html

