namespace Solid.LSP.Wrong
{
public class Vehicle 
    {
        protected bool _isEngineStarted = false;
        public virtual void StartEngine()
        {
            Console.WriteLine("Starting engine...");
            _isEngineStarted = true;
        }
        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating...");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Stopping engine...");
            _isEngineStarted = false;
        }

        public virtual void Brake()
        {
            Console.WriteLine("Braking...");
        }
    }
}