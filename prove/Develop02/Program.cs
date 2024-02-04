using System;

class Program
{
    public Journal journal;
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        //Console.Clear();
        //Console.WriteLine("Hello Develop02 World!");
        Run();
    }
    public string GetPrompt(){

        Random rnd = new Random();
        int num = rnd.Next(0,5);

        string[] prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"};

        
        return prompt[num];
    }
    static public void Run(){

        bool keepGoing = true;
        int input = ShowMenu();
        while (keepGoing == true){
            Console.Clear();
            //showMenu
            if (input == 1){
                //prompt user with a random prompt
                string prompt = GetPrompt();
                //Read in user input
                System.Console.WriteLine(prompt);
                string response = ReadLine();
                
                Entry entry = new Entry(string response, string prompt);
                Journal.AddEntry(Entry entry);

            }
            else if (input == 2)
            {
                //display journal
                string display = Story();
                system.Console.WriteLine(display);

            }
                
            else if (input == 3)
            {
                //save
                System.Console.WriteLine("Please tell me the file to save the journal to.");
                string text = journal.AsString();
            }
            else if (input == 4)
            {
                //load file
                System.Console.WriteLine("Please type in the file.");
                string file = Console.ReadLine();
                //seperate the date respons and prompt with a charactar and parse through it

            }
            else if (input == 5)
            {
            //end time in journal
                keepGoing = false;
            }
            else
            {
                System.Console.WriteLine("The option you chose is not available, please choose from one of the available options");
            }
        }

    }
    static int ShowMenu(){
        Console.WriteLine("Please select option: \n 1.Add entry \n 2.Display Journal \n 3.Save file \n 4.Load Journal \n 5.Quit");
        string input = Console.ReadLine();
        return int.Parse(input);

    }
    public void SaveToFIle()
    {
        
    }
    public void LoadFromFIle(){

    }       

}