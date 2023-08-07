namespace Solid.OCP.Correct
{
    public class CorrectWay
    {
        public static void Test()
        {
            Console.WriteLine("OCP: Open-Closed Principle - Correct way");

            var payroll = new Payroll();
            var worker = new Worker("John Doe", 10, 40);
            var manager = new Manager("Jane Doe", 10, 40, 500m);

            Console.WriteLine($"Worker {worker.Name} has a salary of {payroll.CalculatePay(worker)}");
            Console.WriteLine($"Manager {manager.Name} has a salary of {payroll.CalculatePay(manager)}");

            Console.WriteLine();

        }
    }
}