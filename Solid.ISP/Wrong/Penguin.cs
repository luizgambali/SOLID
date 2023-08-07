/*
    The Penguin class violates the Interface Segregation Principle because it implements the Bird interface, which contains the Fly() method.
    The Penguin class does not need to implement the Fly() method because penguins cannot fly.
*/

namespace Solid.ISP.Wrong
{
    public class Penguin : Bird
    {
        public void Fly()
        {
            //penguins don't fly
        }
        public void Eat()
        {
            Console.WriteLine("Penguin is eating");
        }

        public void Sleep()
        {
            Console.WriteLine("Penguin is sleeping");
        }
    }
}