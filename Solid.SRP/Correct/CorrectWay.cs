namespace Solid.SRP.Correct;

public class CorrectWay
{
    public static void Test()
    {
        Console.WriteLine("SRP: Single Responsibility Principle - Correct way");

        var person = new Person("John Doe", new Email("jhon.doe@email.com"));
        Console.WriteLine($"Person is valid: {person.ValidatePerson()}");

        var personViewer = new PersonViewer();
        personViewer.ShowPersonAsForm(person);
        personViewer.ShowPersonAsTable(person);

        var personRepository = new PersonRepository();
        personRepository.SavePerson(person);
    }
}

