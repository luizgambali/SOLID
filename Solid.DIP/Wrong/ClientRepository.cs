/*
    DIP — Dependency Inversion Principle

    The Dependency Inversion Principle states that “high-level modules should not depend on low-level modules. Both should depend on abstractions.”
    This principle is about the decoupling of modules. When we follow this principle, it allows us to change the low-level modules easily without affecting

    This class create a MySqlDbContext instance in the constructor, so we can only use MySqlDbContext.
*/

namespace Solid.DIP.Wrong
{
    public class ClientRepository
    {
        private MySqlDbContext applicationDbContext;

        public ClientRepository()
        {
            applicationDbContext = new MySqlDbContext();
        }

        public void Add()
        {
            applicationDbContext.Add();
        }
        
        public void Update()
        {
            applicationDbContext.Update();
        }

        public void Delete()
        {
            applicationDbContext.Delete();
        }
    }
}