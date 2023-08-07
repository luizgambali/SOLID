namespace Solid.DIP.Correct
{
    public class MySqlDbContext: IDbContext
    {
        public MySqlDbContext()
        {
            Console.WriteLine("MySqlDbContext created");
        }

        public void Add()
        {
            Console.WriteLine("MySqlDbContext Add");
        }
        public void Update()
        {
            Console.WriteLine("MySqlDbContext Update");
        }
        public void Delete(){
            Console.WriteLine("MySqlDbContext Delete");
        }
    }
}