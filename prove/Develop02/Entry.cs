public class Entry
{
    public string response;
    public string prompt;
    public string date;
    
    public Entry(string Response, string Prompt)
    {
        this.response = Response;
        this.prompt = Prompt;
        this.date = DateTime.Today.ToShortDateString();
    }
    public Entry(string Response, string Prompt, string time)
    {
        this.response = Response;
        this.prompt = Prompt;
        this.date = time;
    }
    
    public string AsString(){
        
        string entry = $"{date}|{prompt}|{response}";
        return entry;
    }

}