namespace Solid.LSP.Correct
{
    public static class CorrectWay
    {
        public static void Test()
        {
            Console.WriteLine("LSP: Liskov Substitution Principle - Correct way");

            var car1 = new Vehicle();
            var car2 = new Car();

            Console.WriteLine("Checking 'Car1' Object...");
            Go(car1);

            Console.WriteLine("Checking 'Car2' Object...");
            Go(car2);
            
        }
        private static void Go(Vehicle vehicle)
        {
            vehicle.StartEngine();
            vehicle.StopEngine();
            vehicle.Accelerate();
            vehicle.Brake();
        }
    }
}