using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Vehicle[] vehicles = new Vehicle[4];

                
                vehicles[0] = new Car("Toyota", "Corolla", 180, "Red", 2020);
                vehicles[1] = new Car("Honda", "Civic", 200, "Blue", 2021);
                vehicles[2] = new Bus(50, "Yellow", 2019);
                vehicles[3] = new Bus(40, "Green", 2018);

              
                foreach (Vehicle vehicle in vehicles)
                {
                    vehicle.ShowInfo();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
    

