namespace Solid.OCP.Correct
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        public decimal HourlyRate { get; private set; }
        public decimal HoursWorked { get; private set; }

        public Employee(string name, decimal hourlyRate, decimal hoursWorked)
        {
            this.Name = name;
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }

        public abstract decimal CalculatePay();
    }
}