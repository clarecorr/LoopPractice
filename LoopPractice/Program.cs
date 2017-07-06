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
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            ////or you can do it without an array
            //int product = 1;
            //for (int i = 1; i <= 10; i++)
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

            ////While loop is used when you want a chunk of code to run only if a condition is met first
            ////While something is TRUE
            ////Rely on bools

            //Console.WriteLine("Enter first name");
            //string firstName = Console.ReadLine();
            //while(firstName.ToUpper() == "DANIEL")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break; //if you don't add break, you will get infinite loop if you enter "daniel"
            //}


            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine();
            //while(playAgain.ToUpper() == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            ////A Do-While loop is similar to a While loop, however Do-While loop is used when you want a chunk 
            ////of code to run AT LEAST ONCE but repeat only if the while condition is met

            ////The structure of a do-while loop looks like this:
            ////do
            ////{
            ////      do something
            ////}
            ////while(condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to the game!");
            //    //Pretend the for the game is here
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");

            ////Ask the user for the class that they would like to add to their gpa calculation
            ////Ask the user the lettergrade for the class (no + or -)
            ////Ask the user if they have another class they would like to add to their gpa calculation
            ////Using a do-while loop repeat the code if the user says "YES"

            //string additionalGrade;
            //do
            //{
            //    Console.WriteLine("What class would you like to add to your GPA calculation?");
            //    Console.WriteLine("What is your lettergrade for {0}?", Console.ReadLine());
            //    Console.ReadLine();
            //    Console.WriteLine("Would you like to add another class to your gpa calculation? YES/NO");
            //    additionalGrade = Console.ReadLine();
            //}
            //while (additionalGrade.ToUpper() == "YES");

            //practice
            Console.WriteLine("How many classes did you take?");
            int number = int.Parse(Console.ReadLine());
            string[] classes = new string[number];
            string[] grades = new string[number];
            Console.WriteLine("Please enter your class names and respective grades as prompted.");
            string answer;

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("Enter a class");
                classes[i] = Console.ReadLine();
                Console.WriteLine("What was your grade in that class?");
                grades[i] = (Console.ReadLine());
            }
            for(int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine(classes[i] + ": " + grades[i]);
            }
                
           

            ////Nested loops
            ////Loop inside of another loop
            ////The inner loop is executed more times than the outer loop
            ////Real life example - Clock

            ////Create a nested loop structure that prints:
            ////1234
            ////1234

            //for(int rows = 1; rows <= 2; rows++)
            //{
            //    for (int columns = 1; columns <= 4; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Print a Triangle
            //Outer loop will go line by line
            //Inner loop will go over different elements in the line
            //Result:
            //1
            //1 2
            //1 2 3
            //1 2 3 4

            //for(int rows = 1; rows <= 4; rows++)
            //{
            //    for(int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("How many rows do you want in your triangle?");
            //int n = int.Parse(Console.ReadLine());
            //for (int row = 1; row <= n; row++)
            //{
            //    for (int col = 1; col <= row; col++)
            //    {
            //        Console.Write(col + " ");
            //    }
            //    Console.WriteLine();
            //}





        }
    }
}
