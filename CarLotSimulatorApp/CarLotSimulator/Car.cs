using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {     // deafult construtor
        public Car()
        {
            CarLot.numberOfCars++;
        }
        //custom constructor
        public Car(string make, string model, int year)
        {
            CarLot.numberOfCars++;
            Make = make; 
            Model = model;
            Year = year;
        }
        //propities
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDrivable { get; set; }
        public int Year { get; set; }
        //Methods
        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"This car's engine goes {noise}");
            
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"This car's horn sounds like {HonkNoise}");
        }




    }
}
