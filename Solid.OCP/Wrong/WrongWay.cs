namespace Solid.OCP.Wrong
{
    public class WrongWay 
    {
        public static void Test()
        {
            Console.WriteLine("OCP: Open-Closed Principle - Wrong way");

            var payroll = new Payroll();
            var employee = new Employee("John Doe", EmployeeType.Worker, 10, 40);
            
            Console.WriteLine($"Employee {employee.Name} has a salary of {payroll.CalculatePay(employee)}");

            employee = new Employee("Jane Doe", EmployeeType.Manager, 10, 40);
            Console.WriteLine($"Employee {employee.Name} has a salary of {payroll.CalculatePay(employee)}");
        }
    }
}