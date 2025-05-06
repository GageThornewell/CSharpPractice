using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //************************    Hello World and text   *************************************


            /*
             Declare and use variables
             */

           Console.WriteLine("Hello World!");


            //Declares a variable, aFriend and assigns it a value, "Bill"
            string aFriend = "Bill";
            //String interpolation
            Console.WriteLine("Hello " + aFriend);


            aFriend = "Maira";
            //String interpolation
            Console.WriteLine("Hello " + aFriend);

            //If you add a $ before the opening quote of the string, you can then include variables, like aFriend, 
            //Inside the string between curly braces
            Console.WriteLine($"Hello {aFriend}");

            //We can use more than one variable between curly braces two print multiple strings in one print statement
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

            //We can also get the length of a string, which is a property
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");

            //A Method is a block of code that implements some action. It has a name, so you can access it

            /*
             Trim

             Suppose your strings have leading or trailing spaces that you dont want to display. You want to trim the spaces from the strings.
             The Trim method and related methods TrimStart and TrimEnd do that work. You can just use those methods to remove
             leading and trailing spaces. Try the following code
             */

            Console.WriteLine("");

            string greeting = "              Hello World";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");


            /*
             Replace

             The Replace method searches for a substring and replaces it with different text. The Replace method takes two parameters
             These parameters are the strings between the parentheses. The first string is the string to search for and the second string
             is the text to replace with it. 

             */

            Console.WriteLine("");
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            //Very useful methods
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());


            /*
             * Search strings
             * 
             * You can use the Contains to see if a string has a substring
             */

            string songLyrics = "You say goodbye, and i say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //Challenge
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));



            //************************    Numbers in C#   *************************************


            /*
             * Explore integer math 
             */

            Console.WriteLine("");

            int a = 18;
            int b = 6;
            int c = a - b;
            Console.WriteLine(c);


            /*
             * Explore order of operations
             */

            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            d = (a + b) / c;
            Console.WriteLine(d);

            /*
             * Explore Integer precision and limits
             */


            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}"); // 3
            Console.WriteLine($"remainder: {e}"); // 2

            //Max values of integers. THey have limits in computer programming
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            //Example of overflow
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");



            /*
             * Work with the double type
             */

            double x = 19;
            double y = 23;
            double z = 8;
            double w = (x + y) / z;
            Console.WriteLine(w);

            double maxD = double.MaxValue; 
            double minD = double.MinValue;
            Console.WriteLine($"The range of double is {minD} to {maxD}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            /*
             * Work with the decimal type
             */

            //Decimal is like double, has a smaller range but more precision

            decimal minDe = decimal.MinValue;
            decimal maxDe = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {minDe} to {maxDe}");

            decimal r = 1.0M;
            decimal t = 3.0M;
            Console.WriteLine(r/ t);


            /* 
             * Area of a circle whose radius is 2.50 centimeters
             */

            double radius = 2.50;
            double area = radius * radius * Math.PI;
            Console.WriteLine($"The area of a circle with radius {radius}cm is {area} cm squared");




            //************************    Tuples and types   *************************************
            //************************    branches and loops   *************************************
            //************************    List collections   *************************************
            //************************    Pattern matching   *************************************


        }
    }
}
