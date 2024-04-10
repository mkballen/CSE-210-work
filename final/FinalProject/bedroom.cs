class bedroom : Hall{
    private bool light_on = true;
    private bool door_open = true;
    private string locations = "";
    
    public override void Room(){
        Console.WriteLine("""
        You enter a smaller room with a twin size bed with a drawer on the oposite wall. Next to the bed is a small night stand.
        back to the wall with the larger drawer is a closet door.

        closet
        nightstand
        drawer
        bed
        Return to Hall
        Invetory

        """);

        while(door_open != false){
            switch (locations){
                case "Return to hall":
                    door_open = true;
                    break;
                case "Invitory":
                Invetory tory = new Invetory();
                tory.Item();
                break;
                case "Bed":
                    Console.WriteLine("The bed is made with nothing interesting on it.");
                    break;
                case "Dresser":
                    Console.WriteLine("When examining the dresser you find nothing.");
                    break;                    
                case "nightstand":
                    Console.WriteLine("You don't find anything in the nightstand.");
                    break;
                
                default:
                    door_open = false;
                    break;
            }        
        }
    }
}