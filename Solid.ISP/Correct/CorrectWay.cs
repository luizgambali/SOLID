namespace Solid.ISP.Correct
{
    public class CorrectWay 
    {
        public static void Test()
        {
            Console.WriteLine("ISP — Interface Segregation Principle - Correct way");
            
            var parrot = new Parrot();

            parrot.Eat();
            parrot.Fly();
            parrot.Sleep();

            var penguin = new Penguin();

            penguin.Eat();
            penguin.Sleep();
            
        }
    }
}