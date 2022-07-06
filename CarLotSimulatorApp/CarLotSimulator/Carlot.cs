using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public static int numberOfCars;
        public List<Car> inventory { get; set; } = new List<Car>();
    }
}
