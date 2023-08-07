/*
    DIP — Dependency Inversion Principle

    The Dependency Inversion Principle states that “high-level modules should not depend on low-level modules. Both should depend on abstractions.”
    This principle is about the decoupling of modules. When we follow this principle, it allows us to change the low-level modules easily without affecting
    the high-level modules.

    This class receive a DbContext as a parameter in the constructor, so we can use any DbContext that implements IDbContext interface.
    This way we can change the DbContext without affecting the ClientRepository class.
*/

namespace Solid.DIP.Correct
{
    public class ClientRepository
    {
        private IDbContext applicationDbContext;

        public ClientRepository(IDbContext context)
        {
            applicationDbContext = context;
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