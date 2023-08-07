/*
    The Car class is inheriting from the Vehicle class and overriding the StartEngine method.
    This class does not violate the Liskov Substitution Principle because it is a true substitute for the Vehicle class.
    We can use the Car class in place of the Vehicle class without any problems.

    The methods return the same data type, and these methods do not work differently than the base class.

    The Car class is a true substitute for the Vehicle class.
*/

namespace Solid.LSP.Correct
{
    public class Car: Vehicle 
    {
        public override void StartEngine()
        {
            Console.WriteLine("You started the engine...");
            _isEngineStarted = true;
        }
        public override void Accelerate()
        {
            if (_isEngineStarted)
                Console.WriteLine("You are accelerating...");
            else
                Console.WriteLine("You need to start the engine first...");
        }

        public override void StopEngine()
        {
            if (_isEngineStarted)
            {
                Console.WriteLine("You turned off the engine...");
                _isEngineStarted = false;
            }
        }

        public override void Brake()
        {
            if (_isEngineStarted)
                Console.WriteLine("You are braking...");
            else
                Console.WriteLine("You need to start the engine first...");
        }
    }
}