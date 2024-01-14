using System;

class Program
{
    static void Main(string[] args)
    {
        //get grade from user
        Console.Write("Please type your grade. ");
        string grade = Console.ReadLine();
        int num = int.Parse(grade);
        
        //letter variable
        string letter = "A";
        
        //Deturmine the letter grade.
            if (num >= 90)
            {
                letter = "A";
            }
            else if (num >= 80)
            {
                letter = "B";
            }
            else if (num >= 70)
            {
                letter = "C";
            }
        
            else if (num > 59)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        //final comments

        if (letter == "A" || letter == "B" || letter == "C")
        {

            
                
                Console.WriteLine($"congradulations, you passed with an {letter}!");
            
        }
        else
        {
            
                Console.WriteLine($"Unfutinately you failed with {letter}. I encourage you to study more.");

        }
    }
}    
    //     if (letter == "A" || letter == "B" || letter == "B")
    //     {
    //         if (letter == "A"){
    //             if ( (num/10) >= 7)
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}!");
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}-!");
    //             }
    //         }
    //         if (letter == "B")
    //         {
    //             if ( (num/10) >= 7)
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}+!");
    //             }
    //             else if ( (num/10) < 7 && (num/10) > 3)
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}!");
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}-!");
    //             }
    //         }
    //         if (letter == "C"){
    //             if ( (num/10) >= 7)
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}+!");
    //             }
    //             else if ( (num/10) < 7 && (num/10) > 3)
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}!");
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"congradulations, you passed with an {letter}-!");
    //             }
    //         }
    //     }
    //     else
    //          if (letter == "D")
    //         {
    //             if ( (num/10) >= 7){
    //                 Console.WriteLine($"Unfutinately you failed with a {letter}+. I encourage you to study more.");
    //             }
    //             else if ( (num/10) < 7 && (num/10) > 3){
    //                 Console.WriteLine($"Unfutinately you failed with a {letter}. I encourage you to study more.");
    //             }
    //             else{
    //                 Console.WriteLine($"Unfutinately you failed with a {letter}-. I encourage you to study more.");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Unfutinately you failed with a F. I encourage you to study more.");
    //         }
    // }
//}