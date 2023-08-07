namespace Solid.DIP.Correct
{
    public class CorrectWay 
    {
        public static void Test()
        {
            Console.WriteLine("DIP — Dependency Inversion Principle - Correct way");    

            var clientMySql = new ClientRepository(new MySqlDbContext());
            clientMySql.Add();
            clientMySql.Update();
            clientMySql.Delete();

            var clientMongoDb = new ClientRepository(new MongoDbContext());
            clientMongoDb.Add();
            clientMongoDb.Update();
            clientMongoDb.Delete();
            
            
        }
    }
}