/*
    Person class is responsible for person data! View, E-mail validation and database access are not your responsibility.
*/

namespace Solid.SRP.Correct;

public class Person
{
    public string Name { get; private set; } = "";
    public Email Email { get; private set; }

    public Person(string name, Email email)
    {
        Name = name;
        Email = email;
    }

    public bool ValidatePerson()
    {
        return Email.ValidateEmail() && !string.IsNullOrEmpty(Name);
    }
}