class ExploreMasterBedroom
{
    private bool light_on;
    private string location;
    private bool door_open;

    public ExploreMasterBedroom()
    {

    }
    public void entry(){
        
        while (door_open != false){
            Console.WriteLine("""
            From the door you see a large spacious room. Infront of you is a king size bed to your left and a dress across fron the
            foot of the bed. Along the same wall is a door. At the head of the bed are two night stands 
            on either side with a lamp on top.
            """);
            
            Console.WriteLine("""
            Return to Hall
            Invetory
            Bed
            Main Dresser
            
            Dresser Left
            Dresser Right
            
            """);
            try{
                location = Console.ReadLine();
            }
            catch (Exception e){
                Console.WriteLine("Please pick a location");
            }
            switch (location){
                case "Return to hall":
                    door_open = true;
                    break;
                case "Invitory":
                Invetory tory = new Invetory();
                tory.Item();
                break;
                case "Bed":
                    SearchBed();
                    break;
                case "Main Dresser":
                    Console.WriteLine("You find nothing in the drawers but you do find a coupon book on top of the dresser.");
                    break;
                case "Dresser Left":
                    Console.WriteLine("You find nothing in the dresser.");
                    break;
                case "Dresser Right":
                    Console.WriteLine("You find nothing in the dresser.");
                    break;
                case "Return to Hall":
                    door_open = false;
                    break;
            }
        }
    }
    public void SearchBed(){
        Console.WriteLine("""
        As you move over to the bed you see the bed made and a card on the bed.

        The card says, "Welcome to the master bedroom. We hope you can find this place suitible to your needs." 
        """);
    }
    //display image
}