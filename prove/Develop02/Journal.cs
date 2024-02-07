using System.Net;

public class Journal{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List <Entry>();

    }

    public Journal(string inport)
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
    public void AddEntry(Entry entry)
    {
        
        entries.Add(entry);
    }
    public void Display()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"{entry.date} {entry.prompt} {entry.response}");
        }
    }

   
    public string AsString() {
        string result = "";                     // string result = "";
        foreach (var item in entries)           // foreach (var item in entries)
        {                                       // {
            result += item.AsString() + "\n";             //     result += item.Story();
        }                                       // }
        return result;                           // return result;
    }
}