class Mindful{
    protected int duration;
    protected string activity;
    public Mindful(){
        this.duration = 1;
        this.activity = "";
    }
    public void MindfulMenu(){
        
        while (activity != "quit") {
            System.Console.WriteLine("Please select from the list of options to bedin your mindfulness activity.");
            System.Console.WriteLine("   1.Breathing Activity");
            System.Console.WriteLine("   2.Refelction Activity");
            System.Console.WriteLine("   3.Listing Activity");
            System.Console.WriteLine("   4. quit");

            activity = Console.ReadLine();

            System.Console.Write("Please provide the length you would like the activity to last. ");
            duration = int.Parse(Console.ReadLine());
            //if(activity == breathing)
            //if else (activity == reflection)
            //if else (activity == listing)
            //else {break}
        }
    }
}