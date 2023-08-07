namespace Solid.DIP.Wrong
{
    public class WrongWay 
    {
        public static void Test()
        {
            Console.WriteLine("DIP — Dependency Inversion Principle - Wrong way");   

            var clientRepository = new ClientRepository();

            clientRepository.Add();
            clientRepository.Update();
            clientRepository.Delete();
                     
        }
    }
}