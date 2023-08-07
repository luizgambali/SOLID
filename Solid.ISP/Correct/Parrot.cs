namespace Solid.ISP.Correct
{
    public class Parrot : FlyingBirds
    {
        public void Eat()
        {
            Console.WriteLine("Parrot is eating");
        }

        public void Fly()
        {
            Console.WriteLine("Parrot is flying");
        }

        public void Sleep()
        {
            Console.WriteLine("Parrot is sleeping");
        }
    }
}