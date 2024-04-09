class Invetory
{
    public void Item(){
        List<string> invetory = new List<string>();
        invetory.Add("flashlights");
        Console.WriteLine("Would like to look at invetory? yes/no ");
        string items = " ";
        items = Console.ReadLine();
        if (items == "yes"){
            
            foreach(string objects in invetory){
                Console.WriteLine(objects);
            }
            Console.WriteLine("Would you like to add to invetory yes/no");
            items = Console.ReadLine();
            if (items == "yes"){
                Console.WriteLine("What would you like to add.");
                string objects = Console.ReadLine();
                invetory.Add(objects);
            }
        }
    }
}