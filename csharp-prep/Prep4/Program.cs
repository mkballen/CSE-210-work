using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        // int i;
        // string s;
        // char c;
        // float f;
        // double d;
        // byte b;

        List<int> myInts = new List<int>();
        int num = -1;
        while (num != 0)
        {
            Console.Write("Please provide any set of numbers. When done press 0.");

            string response = Console.ReadLine();
            num = int.Parse(response);
            
            if (num != 0)
            {
                myInts.Add(num);
            }
            
        }
        //for each is good for list
        int r = 0;
        foreach(int myInt in myInts) {

            r += myInt;
        }
        Console.WriteLine($"The total is: {r}");

        float av = ((float) r) / myInts.Count;
        Console.WriteLine($"The average is: {av}");

        int max = myInts[0];

        foreach(int numbers in myInts)
        {
            if(numbers > max)
            {
                max = numbers;
            }
        }
        Console.WriteLine($"The highest unber is {max}");

    }
}