using System;


namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue"){
                Stories = 5,
                Width = 15.5,
                Depth = 30
            };
            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Fox McCloud");
            Console.WriteLine($"Address:{FiveOneTwoEight.Address}");
             Console.WriteLine("-------------");
            Console.WriteLine($"Designed By {FiveOneTwoEight.Designer}");
            Console.WriteLine($"Constructed on: {FiveOneTwoEight.DateConstructed}");
            Console.WriteLine($"{FiveOneTwoEight.Volume} Cubic Meters");
            Console.WriteLine($"Owned by {FiveOneTwoEight.Owner}");
            Console.WriteLine("==================");
           

            var FiveHundred = new Building("500 Interstate Blvd S"){
                Stories = 3,
                Width = 20,
                Depth = 60
            };
            FiveHundred.Construct();
            FiveHundred.Purchase("John Wark"); 
            Console.WriteLine($"Address:{FiveHundred.Address}");
             Console.WriteLine("-------------");
            Console.WriteLine($"Designed By {FiveHundred.Designer}");
            Console.WriteLine($"Constructed on: {FiveHundred.DateConstructed}");
            Console.WriteLine($"{FiveHundred.Volume} Cubic Meters");
            Console.WriteLine($"Owned by {FiveHundred.Owner}");
            Console.WriteLine("==================");

            var Metropolis = new City("Metropolis");
            Metropolis.Elect("Superman");
            

            Metropolis.Buildings.Add(FiveHundred);
            Metropolis.Buildings.Add(FiveOneTwoEight);

            
            Console.WriteLine($"City: {Metropolis.Name}");
            Console.WriteLine($"Mayor: {Metropolis.Mayor}");
            Console.WriteLine($"Established: {Metropolis.YearEstablished}");

            foreach(Building building in Metropolis.Buildings)
            {
                System.Console.WriteLine($"Address: {building.Address}");
                Console.WriteLine($"Owned: {building.Owner}");
                Console.WriteLine($"Constructed: {building.DateConstructed}");
            }

        
        }
    }
}
