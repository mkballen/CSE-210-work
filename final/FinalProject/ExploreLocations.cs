class Explore{
    protected bool light;
    protected string location;
    protected bool door;

    public Explore(){
        light = false;
        location = "";
        door = false;
    }
    public Explore(bool light, string location, bool door){
        light = false;
        location = "";
        door = false;
    }
    public void Entered(){
        Console.WriteLine("You open the door to the entry of the hous and it is all dark.");

        
    }

    // Console.WriteLine("""You step through the threshold of the door and the house opens up to a simple entry way that leads into 
    //     an inviting living room. There the ho """);
}