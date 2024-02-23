class MathAssignment : Assignment
{
    private string textBookSection = "sec";
    private string problem = "1";

    public MathAssignment(string student, string topic, string textBookSection,string problem) : base(student, topic)
    {
        textBookSection = "book";
        problem = "1";
    }
    public string GetMathAssignment(){
        return $"Section {textBookSection}, Prolblems {problem}";
    }
}