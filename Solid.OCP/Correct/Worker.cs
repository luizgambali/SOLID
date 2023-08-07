namespace Solid.OCP.Correct
{
    public class Worker : Employee
    {
        public Worker(string name, decimal hourlyRate, decimal hoursWorked): base(name, hourlyRate, hoursWorked)
        {
        }
        public override decimal CalculatePay()
        {
            return this.HourlyRate * this.HoursWorked;
        }
    }
}