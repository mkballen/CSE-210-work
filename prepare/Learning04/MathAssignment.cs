class MathAssignment : Assignment
{
    private string textBookSection = "sec";
    private string problem = "1";

    public MathAssignment(string student, string topic, string book, string one) : base(student, topic)
    {
        textBookSection = book;
        problem = one;
    }
    public string GetMathAssignment(){
        return $"Section {textBookSection}, Prolblems {problem}";
    }
}