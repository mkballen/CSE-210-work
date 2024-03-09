class ReflectionActivity : Activity{
    private string[] prompts = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    
    public void GetPrompt(){
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("1. Think of a time when you stood up for someone else.");
        Console.WriteLine("2. Think of a time when you did something really difficult.");
        Console.WriteLine("3. Think of a time when you helped someone in need.");
        Console.WriteLine("4. Think of a time when you did something truly selfless.");
        string think = Console.ReadLine();
    }
    // public string GetSubprompt(){
    //     //prompts = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
    // }
    public void ReflectMemory(){
        for (int i = 0; i < 3; i++){
            Random r = new Random();
            int rInt = r.Next(0, 8);

            Console.WriteLine(rInt);
        }
    }
}