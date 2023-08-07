namespace Solid.DIP.Correct
{
    public class SqlServerDbContext: IDbContext
    {
        public SqlServerDbContext()
        {
            Console.WriteLine("SqlServerDbContext created");
        }

        public void Add()
        {
            Console.WriteLine("SqlServerDbContext Add");
        }
        public void Update()
        {
            Console.WriteLine("SqlServerDbContext Update");
        }
        public void Delete(){
            Console.WriteLine("SqlServerDbContext Delete");
        }
    }
}