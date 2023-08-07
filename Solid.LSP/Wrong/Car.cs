/*
    The Car class is inheriting from the Vehicle class and overriding the StartEngine method.
    
    The problem is that the Accelerate method is throwing an exception if the engine is not started.
    This is a violation of the Liskov Substitution Principle because the Car class is not a true substitute for the Vehicle class.

    
*/

namespace Solid.LSP.Wrong
{
    public class Car: Vehicle 
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting engine...");
            _isEngineStarted = true;
        }

        public override void Accelerate()
        {
            if (!_isEngineStarted)
                throw new Exception("Engine is not started!");
                
            Console.WriteLine("Accelerating...");
        }

        public override void StopEngine()
        {
            if (!_isEngineStarted)
            {
                Console.WriteLine("the engine is already off");    
            }
            else
            {
                Console.WriteLine("Stopping engine...");
                _isEngineStarted = false;
            }
        }
    }
}