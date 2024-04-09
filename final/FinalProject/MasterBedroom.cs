class ExploreMasterBedroom : Explore
{

    public ExploreMasterBedroom(bool is_light_on, string location, bool is_door_open) : base (is_light_on, location, is_door_open)
    {

    }
    public void entry(bool is_door_open){
        
        while (is_door_open != false){
            Console.WriteLine("""
            From the door you see a large spacious room. Infront of you is a king size bed to your left and a dress across fron the
            foot of the bed. Along the same wall is a door. At the head of the bed are two night stands 
            on either side with a lamp on top. On the far wall is a closed curtain.
            """);
            
            Console.WriteLine("""
            Return to Hall
            Invetory
            Bed
            Dresser
            Door
            Dresser Left
            Dresser Right
            Curtains
            """);
            try{
                location = Console.ReadLine();
            }
            catch (Exception e){
                Console.WriteLine("Please pick a location");
            }
            switch (location){
                case "Return to hall":
                    is_door_open = true;
                    break;
                case "Invitory":
                Invetory tory = new Invetory();
                tory.Item();
                break;
                case "Bed":
                    SearchBed();
                    break;
                case "Dresser":
                    //Dresser method
                    break;
                case "Dresser Left":
                    //Dresser Left
                    break;
                case "Dresser Right":
                    //Dresser Right
                    break;
                case "Curtains":
                    break;
                default:
                    is_door_open = false;
                    break;
            }
        }
    }
    public void SearchBed(){
        Console.WriteLine("""
        As you move over to the bed you see the bed made.
        """);
        bool isSearching = true;
        Console.WriteLine("""
        Search under bed
        search under the coverse 
        continue searching
        """);
        string bed = "";
        

        //while 
    }
    //display image
}