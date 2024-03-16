class EternalGoals : Goals {
    
    public EternalGoals(int points, string goalName, string goalDiscription, int numCompletions, int bonusPoints) : base (points, goalName, goalDiscription, numCompletions, bonusPoints){
        
    }
    //question
    public override void AskQuestion(){
        List <string> goal = new List<string>();

        Console.Write("What is the name of the goal? ");
        goal.goalName = Console.ReadLine();
        Console.Write("What is a brief discription of the goal? ");
        goal.goalDiscription = Console.ReadLine();
        Console.Write("How many points is it worth ");
        goal.points = int.Parse(Console.ReadLine());
        
    }
    //display
    public void display(){

    }
    

}