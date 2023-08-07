/*
    OCP: Open-Closed Principle

    The Open-Closed Principle states that “software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.”

    In the 'Wrong' folder, the Payroll class violates the OCP because it is not closed for modification. If a new type of employee is added, the Payroll
    class will need to be modified to handle the new type of employee. This violates the OCP because the Payroll class is not closed for modification.

    In the 'Correct' folder, the Payroll class adheres to the OCP because it is closed for modification. If a new type of employee is added, the Payroll
    class will not need to be modified to handle the new type of employee. This adheres to the OCP because the Payroll class is closed for modification.
*/

using Solid.OCP.Wrong;
using Solid.OCP.Correct;

WrongWay.Test();
CorrectWay.Test();
