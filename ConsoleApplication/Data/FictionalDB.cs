namespace Demo
{
    class FictionalDB
    {
        public static List<TrackCar> GetTrackCars()
        {
            List<TrackCar> trackCars = new()
            {
                new TrackCar()
                {
                    Manufacturer = Manufacturer.Porsche,
                    Model = "911",
                    EngineSize = 3.6,
                    Colour = Colours.White,
                    Horsepower = 460,
                    EngineType = EngineType.V6,
                    Weight = 1400,
                    TyreType = TyreType.SuperHard,
                    Track = Tracks.Silverstone,
                    BestLap = new TimeOnly(0,1,50),
                },
                new TrackCar()
                {
                    Manufacturer = Manufacturer.BMW,
                    Model = "M4",
                    EngineSize = 4.2,
                    Colour = Colours.Black,
                    Horsepower = 360,
                    EngineType = EngineType.V6,
                    Weight = 1300,
                    TyreType = TyreType.SuperHard,
                    Track = Tracks.DoningtonPark,
                    BestLap = new TimeOnly(0,2),
                },
                new TrackCar()
                {
                    Manufacturer = Manufacturer.Nissan,
                    Model = "370Z",
                    EngineSize = 6.0,
                    Colour = Colours.Black,
                    Horsepower = 360,
                    EngineType = EngineType.V8,
                    Weight = 1400,
                    TyreType = TyreType.SuperHard,
                    Track = Tracks.Silverstone,
                    BestLap = new TimeOnly(0,1,30),
                },
                new TrackCar()
                {
                    Manufacturer = Manufacturer.BMW,
                    Model = "M3",
                    EngineSize = 3.2,
                    Colour = Colours.Red,
                    Horsepower = 460,
                    EngineType = EngineType.V6,
                    Weight = 1200,
                    TyreType = TyreType.Hard,
                    Track = Tracks.DoningtonPark,
                    BestLap = new TimeOnly(0, 1, 48),
                },
                new TrackCar()
                {
                    Manufacturer = Manufacturer.Nissan,
                    Model = "GT-R",
                    EngineSize = 4.0,
                    Colour = Colours.Black,
                    Horsepower = 760,
                    EngineType = EngineType.V4,
                    Weight = 1800,
                    TyreType = TyreType.Medium,
                    Track = Tracks.Silverstone,
                    BestLap = new TimeOnly(0, 2, 5),
                },
            };
            return trackCars;
        }
        public static List<RoadCar> GetRoadCars()
        {
            List<RoadCar> carList = new()
            {
                 new RoadCar()
                 {
                     Manufacturer = Manufacturer.Porsche,
                     Model = "Boxster",
                     EngineSize = 2.2,
                     Colour = Colours.Yellow,
                     Horsepower = 300,
                     AnnualTax = 300,
                     EngineType = EngineType.V8,
                     Weight = 1800,
                     TyreType = TyreType.Hard
                 },
                 new RoadCar()
                 {
                     Manufacturer = Manufacturer.Hyundai,
                     Model = "i30",
                     EngineSize = 2.0,
                     Colour = Colours.Red,
                     Horsepower = 100,
                     AnnualTax = 100,
                     EngineType = EngineType.V4,
                     Weight = 1500,
                     TyreType = TyreType.Soft
                 },
                 new RoadCar()
                 {
                     Manufacturer = Manufacturer.Ford,
                     Model = "Mustang"
,                     EngineSize = 5.0,
                     Colour = Colours.Green,
                     Horsepower = 520,
                     AnnualTax = 300,
                     EngineType = EngineType.V8,
                     Weight = 1700,
                     TyreType = TyreType.Hard
                 },
                 new RoadCar()
                 {
                     Manufacturer = Manufacturer.Mercedes,
                     Model = "A Class",
                     EngineSize = 2.5,
                     Colour = Colours.White,
                     Horsepower = 160,
                     AnnualTax = 200,
                     EngineType = EngineType.V4,
                     Weight = 1900,
                     TyreType = TyreType.Medium
                 },
                new RoadCar()
                {
                    Manufacturer = Manufacturer.Ford,
                    Model = "Fiesta",
                    EngineSize = 1.2,
                    Colour = Colours.White,
                    Horsepower = 140,
                    AnnualTax = 120,
                    EngineType = EngineType.V4,
                    Weight = 1850,
                    TyreType = TyreType.Medium
                },
                new RoadCar()
                {
                    Manufacturer = Manufacturer.Porsche,
                    Model = "Macan",
                    EngineSize = 3,
                    Colour = Colours.White,
                    Horsepower = 440,
                    AnnualTax = 220,
                    EngineType = EngineType.V8,
                    Weight = 1650,
                    TyreType = TyreType.Hard
                },
            };
            return carList;
        }
    }
}