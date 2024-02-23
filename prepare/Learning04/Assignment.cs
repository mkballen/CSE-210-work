class Assignment
{
    protected string student = "";
    protected string topic = "";
    public Assignment(string student, string topic){
        this.student = "student";
        this.topic = "topic";
    }
    public string GetStudent(string student){
        return student;
    }
    public void setStudent(string _student){
        student = _student;
    }
    public string GetTopic(string topic){
        return topic;
    }
    public void settopic(string _topic){
        topic = _topic;
    }

    public string GetSummary(string student, string topic){
        return student + "-" + topic;
    }

}