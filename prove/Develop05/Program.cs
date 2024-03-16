using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        //display menu option, goals and points
        var choice = 0;
        
        while(choice != 6){
            
            Console.WriteLine("please select a number option from the below options.");
            string[] prompt = {
            "1.create new goal",
            "2.load",
            "3.save",
            "4.list goals",
            "5.Record event",
            "6.quit"};
            int number = 5;
            for(int i = 0; i <= number; i ++){
                Console.WriteLine(prompt[i]);
            }

            Console.Write("What would like to choose from the menu: ");
            try {
                choice = int.Parse(Console.ReadLine());
            }
            catch(Exception){
                Console.WriteLine("Please choose a number from the option above.");
            }
            
            
            if (choice == 1){
                //create goal
            }
            else if(choice == 2){
                //load
            }
            else if(choice  == 3){
                //save
            }
            else if(choice == 4){
                //list goals
            }
            else if(choice == 5){
                //record event
            }
        }
        
    }
}