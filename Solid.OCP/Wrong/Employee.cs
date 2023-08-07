namespace Solid.OCP.Wrong
{
    public enum EmployeeType
    {
        Worker,
        Manager
    }

    public class Employee
    {
        public string Name { get; private set; }
        public decimal HourlyRate { get; private set; }
        public decimal HoursWorked { get; private set; }

        public EmployeeType Type { get; private set; }

        public Employee(string name, EmployeeType type, decimal hourlyRate, decimal hoursWorked)
        {
            Name = name;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            Type = type;
        }
    }
}