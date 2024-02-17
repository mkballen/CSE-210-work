class Reference
{
    private string book;
    private string chapture;
    private string verse;
    
    public Reference()
    {
        book = "1 Nephi";
        chapture = "1";
        verse = "12";
    }
    //displayRef
    public void Display(){
        System.Console.WriteLine($"{book} {chapture}, {verse} ");
    }
}