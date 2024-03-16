class SimpleGoals{
    //get file segment
    //edit and update
    //mark with x if coplete
    //return up date
    public SimpleGoals(int points, string goalName, string goalDiscription, int numCompletions, int bonusPoints) : base (points, goalName, goalDiscription, numCompletions, bonusPoints){

    }
    public override void GetQuestion(){
        

        Console.Write("What is the name of the goal? ");
        goalName = Console.ReadLine();
        Console.Write("What is a brief discription of the goal? ");
        goalDiscription = Console.ReadLine();
        Console.Write("How many points is it worth ");
        points = int.Parse(Console.ReadLine());        
    }
}