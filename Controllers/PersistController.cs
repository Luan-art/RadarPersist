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
            return persistService.Inserir();
        }
    }
}