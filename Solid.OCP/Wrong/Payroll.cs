/*
    There is a problem here: if we add a new employee type, we have to modify the CalculatePay method.
*/

namespace Solid.OCP.Wrong
{
    public class Payroll
    {
        public decimal CalculatePay(Employee employee)
        {
            switch (employee.Type)
            {
                case EmployeeType.Worker:
                    return employee.HourlyRate * employee.HoursWorked;
                case EmployeeType.Manager:
                    return (employee.HourlyRate * employee.HoursWorked) + 500m; //bonus
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
