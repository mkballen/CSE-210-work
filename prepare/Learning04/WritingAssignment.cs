class WritingAssignment : Assignment
{
    private string title = "";

    public WritingAssignment(string title, string student, string topic) : base(student, topic){
        this.title = "title";
    }
    public string GetWritingInformation(string title, string student){
        return $"{title} by {student}";
    }
}