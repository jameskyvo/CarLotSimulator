using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var carvana = new CarLot();
            

            var ford = new Car();
            carvana.inventory.Add(ford);
            ford.Make = "Ford";
            ford.Model = "F150";
            ford.Year = 1999;
            ford.IsDriveable = true;
            ford.EngineNoise = "Vroom Vroom";
            ford.HonkNoise = "Beeeeeep";
            ford.MakeEngineNoise(ford.EngineNoise);
            ford.MakeHonkNoise(ford.HonkNoise);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot.");
          
            var beetle = new Car(){ Make = "Volkswagen", Model = "Type 1", Year = 2019, IsDriveable = false, EngineNoise = "pbbbbbbbbbbrt", HonkNoise = "meep meep"};
            carvana.inventory.Add(beetle);
            beetle.MakeEngineNoise(beetle.EngineNoise);
            beetle.MakeHonkNoise(beetle.HonkNoise);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot.");

            var tesla = new Car()
            {
                Make = "Tesla",
                Model = "Model S",
                Year = 2022,
                IsDriveable = true,
                EngineNoise = "........",
                HonkNoise = "Roadrage.mp3",
            };
            carvana.inventory.Add(tesla);
            tesla.MakeEngineNoise(tesla.EngineNoise);
            tesla.MakeHonkNoise(tesla.HonkNoise);
            Console.WriteLine($"There are {CarLot.numberOfCars} cars in the lot.");

            foreach (var cars in carvana.inventory)
            {
                Console.WriteLine($"{cars.Make} {cars.Year} {cars.Model}");
            }
            Console.ReadLine();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
