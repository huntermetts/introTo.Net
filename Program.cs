using System;
using System.Collections.Generic;

namespace bangazon
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime is the type of the purchaseData variable.
            DateTime purchaseDate=DateTime.Now;

            /*
                string is the type of the lastName variable. It
                tells the compiler that the lastName variable can
                ONLY hold a string value.
            */
            string lastName="Smith";

            /*
                C# now supports implicitly typing of a variable. The
                type of the variable will be determined, by the
                compiler, at compile time.
            */
            string firstName="John";

            /*
                String interpolation in C# is similar to string interpolation in JavaScript,
                but there is a different syntax.

                An equivalent statement in JavaScript would be:
                console.log(`${firstName} ${lastName} purchased on ${purchaseDate}`);
            */
            Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");

            List<int> myList = new List<int>(){
                1, 2, 3, 4
            };

            int first = myList[0];
            Console.WriteLine($"first: {first}");

            foreach(int num in myList){
                Console.WriteLine(num);
            }


            List<string> products = new List<string>(){
                "Motorcycle",
                "Sofa",
                "Sandals",
                "Omega Watch",
                "iPhone"
            };

            foreach(string product in products) {
                    if (product.Length < 5) {
                        Console.WriteLine($"{product} has a short name");
                    } else if (product.Length < 10) {
                        Console.WriteLine($"{product} has a medium-sized name");
                    } else {
                        Console.WriteLine($"{product} has a long name");
                    }
            }
        }
    }
}