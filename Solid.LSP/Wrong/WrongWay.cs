using System.Runtime.InteropServices.ComTypes;
namespace Solid.LSP.Wrong
{
    public static class WrongWay
    {
        public static void Test()
        {
            Console.WriteLine("LSP: Liskov Substitution Principle - Wrong way");

            var car1 = new Vehicle();
            var car2 = new Car();

            Console.WriteLine("Checking 'Car1' Object...");
            Go(car1);

            Console.WriteLine("Checking 'Car2' Object...");
            Go(car2);
         
        }
        private static void Go(Vehicle vehicle)
        {            
            try
            {
                vehicle.StartEngine();
                vehicle.StopEngine();
                vehicle.Accelerate();
                vehicle.Brake();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ops, something went wrong... " + ex.Message);
            }
            
        } 
    }
}