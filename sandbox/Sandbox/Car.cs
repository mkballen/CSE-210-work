class Car 
    {
        public string model;
        public string make;
        public int milesPerGallon;
        public int gallon;
        public Person owner;

        public int TotalRange(){
            return gallon * milesPerGallon;

        }

        public void Display(){
            System.Console.WriteLine($"{make} {model} {owner.DisplayString}: totalRange = {TotalRange()}");
        }
    }

   