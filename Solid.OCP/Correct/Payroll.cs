/*
    If we need to add a new employee type, we can create a new class that inherits from Employee and override the CalculatePay method.
    We don't need to modify the Payroll class.
*/

namespace Solid.OCP.Correct
{
    public class Payroll
    {
        public decimal CalculatePay(Employee employee)
        {
            return employee.CalculatePay();
        }
    }
}