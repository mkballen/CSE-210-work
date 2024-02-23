class WritingAssignment : Assignment
{
    private string title = "";

    public WritingAssignment(string _title, string student, string topic) : base(student, topic){
        this.title = _title;
    }
    public string GetWritingInformation(){
        return $"{title} by {student}";
    }
}