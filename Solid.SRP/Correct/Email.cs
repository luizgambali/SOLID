/*
    If you nedd to change the e-mail validation, you can modify here, without modifying the other classes.
*/

namespace Solid.SRP.Correct
{
    public class Email
    {
        public string Address { get; private set; } = "";

        public Email(string address)
        {
            Address = address;
        }
        
        public bool ValidateEmail()
        {
            if (string.IsNullOrEmpty(Address) || !Address.Contains("@"))
                return false;

            var prefix = Address.Split("@")[0];
            var suffix = Address.Split("@")[1];

            if (string.IsNullOrEmpty(prefix) || string.IsNullOrEmpty(suffix))
                return false;

            if (prefix.Length < 3 || suffix.Length < 3)
                return false;

            return true;
        }
    }
}