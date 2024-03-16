class Goals
{
    protected int points;
    protected string goalName;
    protected string goalDiscription;
    protected int numCompletions;
    protected int bonusPoints;
    private string goalName;

    public Goals(int point, string _goalName, string _goalDiscription, string _delimeter, int _bonusPoints, int _numCompletions){
        points = point;
        goalName = _goalName;
        goalDiscription = _goalDiscription;
        delimeter = _delimeter;
        numCompletions = _numCompletions;
        bonusPoints = _bonusPoints;
    }
   
    public void ShowMenu(){
        
        Console.WriteLine($"""
        {points}
            1. Eternal Goal
            2. Checklist Goal
            3. Simple Goal

        What kind of goal would you like to make?
        """);
        var choice = int.Parse(Console.ReadLine());
        if (choice == 1){
            EternalGoals.Askquestion();
            goalName = "Eternal Goal";
        }
        else if(choice == 2){
            //checklist
            EternalGoals.Askquestion();
            goalName = "Checklist Goal";
        }
        else if(choice == 3){
            //simple goal
            EternalGoals.Askquestion();
            goalName = "Simple Goal";
        }
    }
    public virtual void AskQuestions(){        
        
    }
    public Goals(string inport)
    {
        string[] date = inport.Split("\n");
        foreach (string entry in date)
        {
            string time = "~|";
            string[] enter = entry.Split(time);
            entries.Add(new Entry(enter[2], enter[1], enter[0]));
        }
    }
    public string Export(){
        string outPut = ""; 
        foreach (Entry en in entries)
        {
            outPut = outPut + $"{en.date}~|{en.prompt}~|{en.response}\n";
        }
        
        return outPut;
    }

   
    public string AsString() {
        string result = "";                     // string result = "";
        foreach (var item in entries)           // foreach (var item in entries)
        {                                       // {
            result += item.AsString() + "\n";             //     result += item.Story();
        }                                       // }
        return result;                           // return result;
    }//public void 
}