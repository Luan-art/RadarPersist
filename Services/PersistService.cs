using Models;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using Repositories;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace Services
{
    public class PersistService
    {
        private IRadarRepository iRadarRepository;
        string caminhoJson = "C:\\Users\\LuanLF\\dados_dos_radares.json";
        public PersistService()
        {
            iRadarRepository = new PersistRepository();
        }

        public bool Inserir()
        {
            Console.WriteLine("Service");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                var radares = GetData(caminhoJson);

                iRadarRepository.Inserir(radares);

                stopwatch.Stop();
                Console.WriteLine($"Tempo de inserção: {stopwatch.ElapsedMilliseconds} milissegundos");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
                return false;
            }
        }

        public static List<Radar>? GetData(string path)
        {
            StreamReader sr = new(path);
            string jsonString = sr.ReadToEnd();

            var settings = new JsonSerializerSettings
            {
                Culture = new CultureInfo("pt-BR"),
                DateFormatString = "dd/MM/yyyy"
            };


            var list = JsonConvert.DeserializeObject<ListaRadares>(jsonString, settings);

            if (list != null) return list.ListaDeRadares;
            return null;
        }

    }
}