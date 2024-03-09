class BreathingActivity : Activity{
  


    // public BreathingActivity(int countIN1, int countOut1, int duration) : base(duration) {
    //     countIn = countIN1;
    //     countOut = countOut1;
    // }

    
    public override void Start(){
        //opening statement.
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        //Duration divided by 3 for count in and count out. 
        for(int i = 0; i < duration; i = i + 3 ){
            Thread.Sleep(1000);
            
            if (i % 2 == 0 ){
                Console.WriteLine("breath in.");
            }
            else{
                Console.WriteLine("breath out.");
            }
            for(int j = 3; j > 0; j--){
                
                Console.Write(j);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
           
        }
        //end statment for finished.
        Console.WriteLine("and done.");
    }







//     Console.WriteLine("Going to sleep for a second...");

// Thread.Sleep(1000);

// Console.WriteLine("I'm back!!");

}