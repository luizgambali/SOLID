namespace Solid.ISP.Wrong
{
    public class WrongWay
    {
        public static void Test()
        {
            Console.WriteLine("ISP — Interface Segregation Principle - Wrong way");
            
            var parrot = new Parrot();

            parrot.Eat();
            parrot.Fly();
            parrot.Sleep();

            var penguin = new Penguin();

            penguin.Eat();
            penguin.Fly();
            penguin.Sleep();
        }
    }
}