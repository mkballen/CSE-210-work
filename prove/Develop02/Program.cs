using System;

class Program
{
    public static Journal journal;
    static void Main(string[] args)
    {
        journal = new Journal();

        //Console.Clear();
        //Console.WriteLine("Hello Develop02 World!");
        Run();
    }

    public static string GetPrompt()
    {

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
    static public void Run()
    {
        bool keepGoing = true;
        int input = ShowMenu();
        while (keepGoing == true){
            Console.Clear();
            //showMenu
            if (input == 1)
            {
                //prompt user with a random prompt
                string prompt = GetPrompt();
                //Read in user input
                System.Console.WriteLine(prompt);
                string response = Console.ReadLine();
                
                Entry entry = new Entry(response, prompt);
                journal.AddEntry(entry);

            }
            else if (input == 2)
            {
                //display journal
                journal.Display();
                
            }
                
            else if (input == 3)
            {
                //save
                System.Console.WriteLine("Please tell me the file to save the journal to.");
                string text = Console.ReadLine();
                SaveToFIle(text , journal.Export());
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

    static int ShowMenu()
    {
        Console.WriteLine("Please select option: \n 1.Add entry \n 2.Display Journal \n 3.Save file \n 4.Load Journal \n 5.Quit");
        string input = Console.ReadLine();
        return int.Parse(input);

    }
    public static void SaveToFIle(string filePath, string data)
    {
        try{
            using(StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(data);
            }
        }
        catch (Exception ex){
            Console.WriteLine("Error saving data: " + ex.Message);
        }
    }
    public static string LoadFromFIle(string filePath)
    {
        try{
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving data: " + ex.Message);
            return null;
        }
    }       

}