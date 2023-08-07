/*
    Here, Penguin implements the IBird interface, which contains the Eat() and Sleep() methods.
    The Penguin class does not need to implement the Fly() method because penguins cannot fly.
*/

namespace Solid.ISP.Correct
{
    public class Penguin : Bird
    {
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