class Assignment
{
    protected string student = "";
    protected string topic = "";
    public Assignment(string _student, string _topic){
        this.student = _student;
        this.topic = _topic;
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

    public string GetSummary(){
        return student + "-" + topic;
    }

}