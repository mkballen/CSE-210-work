using System;

class Program
{
    public static void userInterface()
    {
        Scripture script = new Scripture("And it came to pass that as he read, he was filled with the Spirit of the Lord.");
        Reference reference = new Reference();
        
        var move = false;
        while (move != true)
        { 
            Console.Clear();
            Console.WriteLine("Please hit enter to continue, or you can hit quit to end. ");
                reference.Display();
                script.Display();
            
            string quit = Console.ReadLine();
            if (quit == "quit")
            {
                break;
            }

            else
            {
                move = script.Leave();
                //Hide some words
                script.HideWords();
                //check if all the words are hidden - exit if they are
                
            }

            
        } 
    }
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        userInterface();
    }
}