/*
    If you need to change data access from a person, you can add or modify here, without modifying the Person class.
*/

namespace Solid.SRP.Correct;

public class PersonRepository
{
    public void SavePerson(Person p)
    {
        if (p.ValidatePerson())
        {
            // Save to database
            Console.WriteLine($"Saving {p.Name} to database...");
        }
    }
}