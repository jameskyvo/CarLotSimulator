using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise(string engineNoise) // would prefer to work directly with property instead of string parameter
        {
            Console.WriteLine(engineNoise);
        }

        public void MakeHonkNoise(string honkNoise) // see above comment
        {
            Console.WriteLine(honkNoise);
        }
    }
}
