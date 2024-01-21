using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
    //     //Console.WriteLine("Hello Prep3 World!");
    //     int count = 0;
    //     //while loop
    //     while (count < 5)
    //     {
    //         System.Console.WriteLine($"count = {count}");
    //         count += 1;
    //     }
    // //do-while loop
    //     int moreCount = 0;
    //     do 
    //     {
    //         System.Console.WriteLine($"moreCount = {moreCount++}");
    //     }while(moreCount < 5);

        // //for loop
        // for (var i = 0; i < 5; ++i)
        // {
        //     System.Console.WriteLine($"i = {i}");
        // }

        // // assignment 3
        Random randomGenerator = new Random();
int     number = randomGenerator.Next(1, 11);
        int guess;
        do 
        {
            Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your number is to high.");
            }
            else if (guess < number)
            {
                Console.WriteLine("Your guess is to lower.");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        
        }while (guess != number);
    }
}