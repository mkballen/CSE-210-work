using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name. ");
        string First = Console.ReadLine();
        Console.Write("what is your last name. ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {First} {last}.");
    }
}