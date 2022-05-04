using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{ //Create a CarLot class--Done
  //It should have at least one property: a List of cars--Done
  //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.---done
  //At the end iterate through the list printing each of car's Year, Make, and Model to the console---done
  //using .Notation---done
  //Building on our car lot simulator project, create a CarLot class with a static field called numberOfCars.--done
  //Have this number only increment when in our program we create a new Car.---done
  //From there create 3 cars in the Main() and then each time you create a car, do a Console.WriteLine() printing the current number of cars in the car lot.--done

    internal class CarLot
    {
        public List<Car> ParkingLot { get; set; } = new List<Car>();
        public static int numberOfCars = 0;
    }
}
