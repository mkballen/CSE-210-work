using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcom to the house!");
        BeginExplore();
    }
    static void BeginExplore(){
        var explore = new Explore(); 
        bool end = false;
        string enter = "";
        while (end != true){
            Console.WriteLine("would like to enter the house and explore? yes/no");
            enter = Console.ReadLine();
            if (enter == "yes"){
                explore.Entered();
            }
            else if (enter == "no"){
                Console.WriteLine("Thank you for playing or visiting, have a nice day. :) ");
                end = true;
            }
            
        }
    }
}