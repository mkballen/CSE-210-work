class Explore{
    protected bool is_light_on;
    protected string location;
    protected bool is_door_open;

    public Explore(){
        is_light_on = true;
        location = "";
        is_door_open = true;
    }
    public Explore(bool light, string location, bool door){
        is_light_on = true;
        location = "";
        is_door_open = true;
    }
    public void Entered(){
        string light = "";
        Console.WriteLine("You open the door to the entry of the house and it is all dark.");
        Console.WriteLine("Would like to turn on a light? yes/no ");
        light = Console.ReadLine();
        while (is_light_on != false){
            
            if (light == "yes"){
                
                entryway();
                is_light_on = true;
                break;
            }
            else if (light == "no"){
                while (is_light_on == false){
                    Console.WriteLine("would like to leave? yes/no ");
                    if (light != "yes"){
                        break;
                    }
                }
                break;
            }
        }    
    }
    public void entryway(){
        Console.WriteLine(
        """
        When the light turns on the space opens up to an open space. When look to your left you see a living room and on the far side
        side you see the entry to the hall. To your left you see the kichen and the dining room.
        What would like to see first?

        hall
        kichen
        dining room
        living room
        invetory
        leave
        """
        );
        string location = "";
        
        while (is_door_open != false){
            location = Console.ReadLine();
            if (location == "hall"){
                Hall hall = new Hall();
                hall.ViewingHall();
                
            }
            else if (location == "kichen"){
                //kichen
                
            }
            else if (location == "dining room"){
                //dining room
                
            }
            else if (location == "living room"){
                //living rooom
                
            }
            else if (location == "invetory"){
                Invetory tory = new Invetory();
                tory.Item();
                
            }
            else if (location == "leave"){
                is_door_open = false;
            }
            else {
                Console.WriteLine("Please check your spelling or select the options listed above.");
            }
        }
    }  
}