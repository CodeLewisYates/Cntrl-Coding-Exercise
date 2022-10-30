
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<RoadCar> roadCars = FictionalDB.GetRoadCars();
            List<TrackCar> trackCars = FictionalDB.GetTrackCars();

            // annual tax query
            Console.WriteLine("Query for road cars with annual tax under £300\t(Enter)");
            Console.ReadLine();

            List<RoadCar> roadCarsUnderTax = (from car in roadCars where car.AnnualTax <= 300 select car).ToList();
            foreach (RoadCar car in roadCarsUnderTax)
                Console.WriteLine($"{car.Manufacturer} - {car.Model} - £{car.AnnualTax}");


            // all road cars and track cars for porsches query
            Console.WriteLine("\nQuery for all track cars with a best time under 2 minutes\t(Enter)");
            Console.ReadLine();

            List<TrackCar> trackCarsBestTimes = trackCars.Where(car => car.BestLap <= new TimeOnly(0, 2)).ToList();
            foreach (TrackCar trackCar in trackCarsBestTimes)
                Console.WriteLine($"{trackCar.Manufacturer} - {trackCar.Model} - {trackCar.BestLap:mm:ss} - {trackCar.Horsepower} HP - {trackCar.TyreType} Tyres");


            // all road cars and track cars for porsches query
            Console.WriteLine("\nQuery for all Porsches\t(Enter)");
            Console.ReadLine();

            List<Car> allPorsches = (from car in roadCars.Union<Car>(trackCars) where car.Manufacturer == Manufacturer.Porsche select car).ToList();
            Console.WriteLine($"There are {allPorsches.Count} porsches");
            foreach (Car car in allPorsches)
                Console.WriteLine($"{car.Manufacturer} - {car.Model} - {car.Colour} - {car.TyreType} Tyres - {car.EngineSize} Litre - {car.Horsepower} HP");

            Console.ReadLine();
        }
    }
}