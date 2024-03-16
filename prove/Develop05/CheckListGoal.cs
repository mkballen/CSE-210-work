class CheckListGoal{
    //get file segment
    //edit file
    //if completed mark as x
    public CheckListGoal(int points, string goalName, string goalDiscription, int numCompletions, int bonusPoints) : base (points, goalName, goalDiscription, numCompletions, bonusPoints){

    }

    public override void AskQuestion(){
        List <string> goal = new List<string>();

        Console.Write("What is the name of the goal? ");
        goal.goalName = Console.ReadLine();
        Console.Write("What is a brief discription of the goal? ");
        goal.goalDiscription = Console.ReadLine();
        Console.Write("How many points is it worth? ");
        goal.points = int.Parse(Console.ReadLine());
        Console.Write("How many times do you want this complete? ");
        goal.numCompletions = int.Parse(Console.ReadLine());
        Console.Write("How much for bonus points? ");
        goal.bonusPoints = int.Parse(Console.ReadLine());

        
    }
    //return update
}