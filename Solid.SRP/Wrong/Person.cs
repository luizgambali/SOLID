/*
    Person class here is responsible for person data, view and database access! This is not your responsibility.
*/

namespace Solid.SRP.Wrong
{
    public class Person
    {
        public string Name { get; private set; } = "";
        public string Email { get; private set; } = "";

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }
        
        public bool ValidatePerson()
        {
            if (string.IsNullOrEmpty(Name))
                return false;

            if (string.IsNullOrEmpty(Email))
                return false;

            if (!Email.Contains("@"))
                return false;

            var prefix = Email.Split("@")[0];
            var suffix = Email.Split("@")[1];

            if (string.IsNullOrEmpty(prefix) || string.IsNullOrEmpty(suffix))
                return false;

            if (prefix.Length < 3 || suffix.Length < 3)
                return false;

            return true;
        }

        public void ShowPersonAsForm(Person p)
        {
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"Email: {p.Email}");
        }

        public void ShowPersonAsTable(Person p)
        {
            Console.WriteLine($"{p.Name} | {p.Email}");
        }

        public void SavePerson()
        {
            if (ValidatePerson())
            {
                Console.WriteLine($"Saving {Name} to database...");
            }
        }
    }
}