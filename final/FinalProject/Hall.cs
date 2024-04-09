class Hall{
    private bool light_on = true;
    private bool door_open = true;
    private string locations = "";

    public Hall(){

    }
    public void ViewingHall(){
        Console.WriteLine("""
        Opon entering the hall you see three doors. Two doors take you to a bedroom and 
        the last will take you to the bathroom. Where would you like to go?

        bedroom 1
        bedroom 2
        bathroom
        leave

        """);
        locations = Console.ReadLine();
        while (door_open != false){
            if (locations == "bedroom 1"){
                //master bedroom
                break;
            }
            else if(locations == "bedroom 2"){
                //kids bedroom
                break;
            }
            else if(locations == "bathroom"){
                //bathroom
                break;
            }
            else if (locations == "leave"){
                door_open = false;
                break;
            }
            else{
                Console.WriteLine("Please use the options above or check spelling and capitalization");
                break;
            }

        }
    }
}