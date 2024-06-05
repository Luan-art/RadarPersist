using Services;

namespace Controllers
{
    public class PersistController
    {
        private PersistService persistService;

        public PersistController()
        {
            persistService = new PersistService();
        }

        public bool Inserir()
        {
            Console.WriteLine("Controller");
            return persistService.Inserir();
        }
    }
}