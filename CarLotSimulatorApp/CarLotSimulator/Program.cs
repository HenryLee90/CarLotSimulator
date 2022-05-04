using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car--done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable---Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()----Done
            //The methods should take one string parameter: the respective noise property----Done


            //Now that the Car class is created we can instanciate 3 new cars---Done
            //Set the properties for each of the cars---Done
            //Call each of the methods for each car---Done

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car----Done

            //*************BONUS X 2*************//

           
            Car firstCar = new Car();
            firstCar.Make = ("Ford");
            firstCar.Model = "Mustang";
            firstCar.Year = 2000;
            firstCar.IsDrivable = false;
            firstCar.EngineNoise = "Click Clank Bonk Pow";
            firstCar.HonkNoise = "BeepBeep";
            Console.WriteLine($"THere is this many {CarLot.numberOfCars} cars u=in my lot.");
            //Console.WriteLine($"Make: {firstCar.Make}, Model: {firstCar.Model}, Year: {firstCar.Year}, Is drivable: {firstCar.IsDrivable}, Enigine Noise: {firstCar.EngineNoise}, Horn Sound: {firstCar.HonkNoise}");
            //using objest Initializer Syntax
            Car secondCar = new Car()
            {
                Make = "Tesla",
                Model = "S",
                Year = 2022,
                IsDrivable = true,
                EngineNoise = "Nothing",
                HonkNoise = "Honk!!!"
                
            };
            Console.WriteLine($"There is this many {CarLot.numberOfCars} cars in my lot.");
            //Custom Constructor
            Car thirdCar = new Car("lamborghini", "Hurcan STO", 2022);
            Console.WriteLine($"There is this many {CarLot.numberOfCars} cars in my lot.");
        }
    }
}
