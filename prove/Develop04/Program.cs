using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
    
        
        int option = 0;
        while (option != 4) {
            Console.Clear();
            System.Console.WriteLine("Please select the number from the list of options to bedin your mindfulness activity.");
            System.Console.WriteLine("   1.Breathing Activity");
            System.Console.WriteLine("   2.Refelction Activity");
            System.Console.WriteLine("   3.Listing Activity");
            System.Console.WriteLine("   4.quit");
            Activity? activity = null;
            
            
            if (int.TryParse(Console.ReadLine(), out int num)){
                option = num;
            }
            else{
                Console.WriteLine("Wrong input");
                continue;
            }
            
            
            
            
            if(option == 1){
                activity = new BreathingActivity();
                activity.GetTime();
                activity.GetReady();
                activity.Start();
            }
            else if(option == 2){
                activity = new ReflectionActivity();
                activity.IdelDisplay();
                activity.ReflectMemory();
            }
            else if (option == 3){

            }
            if (activity is not null) {
                
                
            }
        }
    }
}