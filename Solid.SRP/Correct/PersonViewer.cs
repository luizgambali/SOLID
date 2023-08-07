/*
    If you want to change the view of a person, you can add or modify here, without modifying the Person class.
*/

namespace Solid.SRP.Correct;

public class PersonViewer
{
    public void ShowPersonAsForm(Person p)
    {
        Console.WriteLine($"Name: {p.Name}");
        Console.WriteLine($"Email: {p.Email.Address}");
    }

    public void ShowPersonAsTable(Person p)
    {
        Console.WriteLine($"{p.Name} | {p.Email.Address}");
    }

}