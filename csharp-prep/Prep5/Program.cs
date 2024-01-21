using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        int userNumber(){
            Console.Write("Please provide a number. ");
            int num = int.Parse(Console.ReadLine());
            
            return num;
        }
        string userName(){
            Console.Write("Please provide your name. ");
            string name = Console.ReadLine();
            
            return name;
        }
        int squareNum(){
            int num = userNumber();
            int square = num * num;
            Console.WriteLine($"The number you chase squared is: {square}");
            return square;

        }
        void displayWelcome(){
            System.Console.WriteLine("WELCOME TO THE PROGRAM!!!");
        }
        void displayAll(){
            string name = userName();
            Console.WriteLine($"Oh, so your name is {name}");
            int number = userNumber();
            Console.WriteLine($"Oh, so your the number your chose is {number}");
            int square = squareNum();
            Console.WriteLine($"The number you chase squared is: {square}");
        }
        displayWelcome();
        displayAll();
        
        

       
    }
}