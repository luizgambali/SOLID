namespace Solid.SRP.Wrong;

public class WrongWay 
{
    public static void Test()
    {
        Console.WriteLine("SRP: Single Responsibility Principle - Wrong way");

        var person = new Person("John Doe", "jhon.doe@email.com");
        Console.WriteLine($"Person is valid: {person.ValidatePerson()}");

        person.ShowPersonAsForm(person);
        person.ShowPersonAsTable(person);
        person.SavePerson();
    }
}