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

            //Without .Reverse
            //string story = "Once upon a time";
            //string[] storyWords = story.Split();
            //for(int i = (storyWords.Length -1); i >= 0; i--)
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

            ////practice
            //Console.WriteLine("How many classes did you take?");
            //int number = int.Parse(Console.ReadLine());
            //string[] classes = new string[number];
            //string[] grades = new string[number];
            //Console.WriteLine("Please enter your class names and respective grades as prompted.");
            //string answer;

            //for (int i = 0; i < classes.Length; i++)
            //{
            //    Console.WriteLine("Enter a class");
            //    classes[i] = Console.ReadLine();
            //    Console.WriteLine("What was your grade in that class?");
            //    grades[i] = (Console.ReadLine());
            //}
            //for(int i = 0; i < classes.Length; i++)
            //{
            //    Console.WriteLine(classes[i] + ": " + grades[i]);
            //}



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

            //for (int rows = 1; rows <= 4; rows++)
            //{
            //    for (int columns = 1; columns <= rows; columns++)
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

            //write a console application that prints hello world to the console 10 times

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("hello world");
            //}

            //create a string variable and print all the elements of that string to the console

            //string greeting = "Hello. How are you?";
            //for(int i = 0; i < greeting.Length; i++)
            //{
            //    Console.WriteLine(greeting[i]);
            //}
            ////or
            //foreach(char word in greeting)
            //{
            //    Console.WriteLine(word);
            //}

            //write a console application that asks the user for word, print the number of vowels in that word to the console

            //Console.WriteLine("Please enter a word");
            //string word = Console.ReadLine();
            //int vowelCount = 0;
            //foreach(char letter in word)
            //{
            //    if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            //    {
            //        vowelCount += 1;
            //    }
            //}
            //Console.WriteLine(vowelCount);

            //write a program which asks the user for a number and how many times that number should be repeated

            //Console.WriteLine("Enter a number");
            //string number = Console.ReadLine();
            //Console.WriteLine("How many times should the number be repeated");
            //int repeatTimes = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= repeatTimes; i++)
            //{
            //    Console.WriteLine(number);
            //}

            //Create an array of lucky numbers and using foreach loop print each

            //int[] luckyNumbers = { 4, 2, 8, 12, 3 };
            //foreach(int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your lucky number is: " + number);
            //}

            //Write a program that prints a multiplication table (5 x 5, for example) using a nested loops.

            //for (int i = 0; i <= 10; i++)
            //{
            //    int product = 5 * i;
            //    Console.WriteLine("5 x {0} = {1}", i, product);
            //}

            //for (int rows = 1; rows <= 5; rows++)
            //{
            //    for (int columns = 1; columns <= 5; columns++)
            //    {
            //        Console.Write(columns * rows + "\t");
            //    }
            //    Console.WriteLine();
            //}


            //Write a console application that asks the user for an integer. 
            //If that integer is evenly divisible by 3, then write “You Won!” If it isn’t, write “You Lost.” 
            //Keep asking them for a number (looping) until they win.



            //int remainder;
            //Console.WriteLine("Enter an integer");
            //int input = int.Parse(Console.ReadLine());
            //remainder = input % 3;
            //if (remainder == 0)
            //{
            //    Console.WriteLine("You Won!");
            //}
            //else
            //{

            //    do
            //    {
            //        Console.WriteLine("You Lost.");
            //        Console.WriteLine("Enter an integer");
            //        input = int.Parse(Console.ReadLine());
            //        remainder = input % 3;
            //        if (remainder == 0)
            //        {
            //            Console.WriteLine("You Won!");
            //        }
            //    }
            //    while (remainder != 0);
            //}

            //simpler way

            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());
            while(input % 3 != 0)
            {
                Console.WriteLine("You lost.");
                Console.WriteLine("Enter another number");
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You won!");


            //Create an array of your favorite movies.Print out each movie in the list, unless the move starts with a vowel. 
            //Hint: Research.startsWith()

            //string[] faveMovies = { "Star Wars", "Anchorman", "Avatar", "Serenity", "Super Troopers" };
            //foreach(string movie in faveMovies)
            //{
            //    if(movie.ToLower().StartsWith("a"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("E"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("I"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("O"))
            //    {
            //        continue;
            //    }
            //    else if (movie.StartsWith("U"))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(movie);
            //    }
            //}



        }
    }
}
