namespace Solid.DIP.Correct
{
    public class MongoDbContext: IDbContext
    {
        public MongoDbContext()
        {
            Console.WriteLine("MongoDbContext created");
        }

        public void Add()
        {
            Console.WriteLine("MongoDbContext Add");
        }
        public void Update()
        {
            Console.WriteLine("MongoDbContext Update");
        }
        public void Delete(){
            Console.WriteLine("MongoDbContext Delete");
        }
    }
}