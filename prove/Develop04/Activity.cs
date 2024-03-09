class Activity{
    protected int duration;
    
    private List<string> animation = new List<string>() {"|","\\","/","|","\\","/"};
    
    public void SelectActivity(int option){
        if(option == 1){
                BreathingActivity breath = new BreathingActivity();
            }
            else if(option == 2){
                ReflectionActivity reflect = new ReflectionActivity();
            }
            else if (option == 3){
                //ListingActivity memory = new ListingActivity();
            }
    }
    public void GetTime(){   
        bool alive = true;
        while (alive){
            try{
                Console.Write("Please give length of time for this activity.");
                duration = int.Parse(Console.ReadLine());
                alive = false;
            }
            catch(FormatException){
                Console.WriteLine("Please provide a valid number.");
            }
        }
    }
    public void GetReady(){
        Console.WriteLine("Get ready");
        for (int i = 5; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public virtual void Start(){
        Console.WriteLine("Not implemented");
    }
    public void IdelDisplay(){
        for(int i = 0; i < duration/5; i++){

            foreach(string animate in animation){
                Console.Write($"{animate}");
                Thread.Sleep(1000);
                Console.Write("\r" + new string(' ', Console.WindowWidth) + "\r");
            }
        }
    }
}