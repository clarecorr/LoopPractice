using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //when you would use a loop
            //why you would use a loop
            //nested loops
            //infinite loops
            //keywords break and continue

            //For Loop
            //can be used for both counting and iterating through an array (or other collection type)
            //Looks like this:
            //for(initializer; condition; updater)
            //{
            //      do something
            //}

            //for(int i = 15; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            ////use for loop to print contents of an array

            //string greeting = "My name is Little Bill.";
            ////the .Split() method takes a string and turns it into an array of smaller strings(substrings). it defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split();
            ////for loop to print the words
            //for(int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //Create an array called days with the elements Monday, Tuesday, and Wednesday
            //Using a For Loop, print the elements of the days array

            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //Start with the string "Once upon a time" and create an array called storyWords using the Split methond. 
            //Reverse the order of the elements in the array and using a for loop, print each word

            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //Add the product of 1 through 10 using a For Loop 
            //Print the product to the screen

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int product = numbers[0];
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //int product = 1;
            //for(int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);



            //for (int i = 1; i <= 10; i++)
            //{
            //    int product = i * (i + 1);
            //    for(product = 2; product > 0; )
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            ////*For each loop
            ////used to itierate over a collection (ex. list or array)
            ////you can think of the structure of a foreach loop as the statement
            ////For each item in the collection, do something

            ////ex
            //int[] studentGrades = { 4, 4, 3, 4, 3 };
            //foreach(int grade in studentGrades)
            //{
            //    Console.WriteLine(grade);
            //}

            //string[] firstMonths = { "Jan", "Feb", "Mar", "April", "May", "June" };
            ////always start with keyword foreach
            //foreach (string month in firstMonths)
            //{
            //    Console.WriteLine(month);
            //}
            ////foreach loops allow the temporary variable to "know" to assign itself to each element 
            ////in the collection(like an array), one at a time

            ////Foreach loop willl always go from beginning to end, no matter what it counts the number of 
            ////elements in the collection, and runs that number of times

            ////Create an array of 6 musicians (bands or solo artists)
            ////Using a foreach loop, print each musician's name

            //string[] musicians = { "Adele", "Beyonce", "Kanye", "Cher", "JT", };
            //foreach(string name in musicians)
            //{
            //    Console.WriteLine(name);
            //}

            //While loop is used when you want a chunk of code to run only if a condition is met first
            //While something is TRUE
            //Rely on bools

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            while(firstName.ToUpper() == "DANIEL")
            {
                Console.WriteLine("Dude, you are amazing.");
                break; //if you don't add break, you will get infinite loop if you enter "daniel"
            }

        }
    }
}
