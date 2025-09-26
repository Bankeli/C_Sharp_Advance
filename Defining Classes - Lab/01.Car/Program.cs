namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           Car car = new Car
           {
               Make = "Audi",
               Model = "A3",
               Year = 2005
           };

            Console.WriteLine($"My car is : {car.Make} {car.Model} {car.Year} year.");
        }
    }
}
