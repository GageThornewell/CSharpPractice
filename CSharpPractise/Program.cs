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
            //************************    Tuples and types   *************************************
            //************************    branches and loops   *************************************
            //************************    List collections   *************************************
            //************************    Pattern matching   *************************************


        }
    }
}
