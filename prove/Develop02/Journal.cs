public class Journal{
    public List<Entry> entries;
    public Journal
    {
        List entries = new List <Entry>();

    }

    public Journal(string inport)
    {

    }
    public void AddEntry(Entry entry)
    {
        
        entries.Add(entry);
    }
    public void Display()
    {
        System
    }

    public string Export()
    {
        return "";
    }

    public string AsString() {
        string result = "";                     // string result = "";
        foreach (var item in entries)           // foreach (var item in entries)
        {                                       // {
            result += item.Story();             //     result += item.Story();
        }                                       // }
        return result;                           // return result;
    }
}