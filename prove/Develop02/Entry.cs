public class Entry
{
    public string Response;
    public string Prompt;
    public string Date;
    
    public Entry(string Response, string Prompt)
    {
        this.Response = Response;
        this.Prompt = Prompt;
        this.Date = DateTime.Today.ToShortDateString();
    }
    
    public Story(){
        this.Response;
        this.Prompt;
        this.Date;
        string journal = ReadLine({Date} {Prompt} {Response});
        return ;
    }

}