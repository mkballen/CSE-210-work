using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        var owner = new List<Person>();

        var cars = new List<Car>();
        Car car = new Car();
        car.make = "honda";
        car.model = "Civic";
        car.gallon = 10;
        car.milesPerGallon = 30;

        owner.name = "bob";
        owner.phone = "333-3333";
        car.owner = owner;

        cars.Add(car);

        car = new Car();
        car.make = "ford";
        car.model = "F-150";
        car.gallon = 30;
        car.milesPerGallon = 5;

        owner.name = "sue";
        owner.phone = "333-4444";
        car.owner = owner;
        cars.Add(car);

        foreach (var c in cars){
            c.Display();

            //System.Console.WriteLine($"{c.make} {c.model}: totalRange = {c.TotalRange()}");
        }

    }
    
}