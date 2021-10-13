using System;

namespace HelloWorld
{
    class Program
    {
        private static string primes;

        static void Main(string[] args)
        {

            int number1 = 31;
            int number2 = 1;
            int number3 = 9;
            
            int intresult = number1 + number2;
            int intresult2 = number1 + number3;

            string HelloWorldVariable = " Jelena";
            string HelloWorldVariable2 = " 31";
          
            string number4 = "20";
            string number5 = "19";
            string number6 = "1";
            string number7 = "9";
            string stringresult = number4 + number5;
            string stringresult2 = number6 + number7;
            primes = String.Format("I visited Greece 4 times: {0}, {1}, {2}, {3}",
                       2012, 2017, 2019, 2029);
            int integerVariable = 1;
            long longVariable = 179;
            decimal decimalVariable = 174.74m;
            string stringVariable = "6";

            string result = stringVariable + integerVariable.ToString();
            int intedecimalVariable = (int)decimalVariable;
            int intlongVariable = (int)longVariable;

            Console.WriteLine(HelloWorldVariable);
            Console.WriteLine("My name is" + HelloWorldVariable);
            Console.WriteLine("I am" + HelloWorldVariable2 + " years old.");
            Console.WriteLine($"Next year I will be {intresult}.");
            Console.WriteLine($"My weight is {result} kg.");
            Console.WriteLine($"My height is {intedecimalVariable}.");
            Console.WriteLine($"My dream height is {intlongVariable}.");
            Console.WriteLine("I was born and raised in Rezekne in Latgale Region of eastern Latvia.\nAfter finishing school I moved to Riga to study at university.");
            Console.WriteLine("Since school years I had tried different hobbies.");
            Console.WriteLine("Some of them were very active such as cycling and dancing - I even participated in dance competitions.");
            Console.WriteLine("Some of the hobbies were ver calm such as Bikram yoga.");
            Console.WriteLine("Some of them were very creative like photography, make-up course and floral design.");
            Console.WriteLine("Time has passed and my interests have changed as well.");
            Console.WriteLine("What I really love are travelling and dogs.");
            Console.WriteLine($"I have visited {stringresult2} countries so far.");
            Console.WriteLine(primes);
            Console.WriteLine($"My farthest journey was Philippines in {stringresult}.");
            Console.ReadLine();

           


        }
    }
}
