namespace Solid.OCP.Correct
{
    public class Manager : Employee
    {
        public decimal Bonus { get; private set; }
        
        public Manager(string name, decimal hourlyRate, decimal hoursWorked, decimal bonus): base(name, hourlyRate, hoursWorked)
        {
            Bonus = bonus;
        }

        public override decimal CalculatePay()
        {
            return (this.HourlyRate * this.HoursWorked) + Bonus;
        }
    }
}