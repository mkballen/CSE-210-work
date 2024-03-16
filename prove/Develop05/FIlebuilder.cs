class FileBuilder{

    //load file
    public static void SaveToFIle(string filePath, string data)
    {
        try{
            using(StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(data);
            }
        }
        catch (Exception ex){
            Console.WriteLine("Error saving data: " + ex.Message);
        }
    }
    public static string LoadFromFIle(string filePath)
    {
        try{
            using (StreamReader reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving data: " + ex.Message);
            return null;
        }
    }   
    //  request file name
    //save file
    //  request file name
    //write to file
    //readfile
    //  request file name

}