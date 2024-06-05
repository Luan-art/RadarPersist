using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class PersistRepository : IRadarRepository
    {
        public bool Inserir(List<Radar> radars)
        {
            string strConn = "Data Source=127.0.0.1; Initial Catalog=BDRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            bool result = false;
            string sql = "INSERT INTO Radar (concessionaria, ano_do_pnv_snv, tipo_de_radar, rodovia, uf, km_m, municipio, tipo_pista, sentido, situacao, data_da_inativacao, latitude, longitude, velocidade_leve) VALUES ";
            try
            {
                using (var db = new SqlConnection(strConn))  
                {
                    db.Open();

                    int batchSize = 100;
                    List<Radar> batch = new List<Radar>();

                    for (int i = 0; i < radars.Count; i++)
                    {
                        batch.Add(radars[i]);

                        if (batch.Count == batchSize || radars[i].ano_do_pnv_snv != null)
                        {
                            string batchSql = sql + string.Join(",", Enumerable.Repeat("(@concessionaria, @ano_do_pnv_snv, @tipo_de_radar, @rodovia, @uf, @km_m, @municipio, @tipo_pista, @sentido, @situacao, @data_da_inativacao, @latitude, @longitude, @velocidade_leve)", batch.Count));

                            db.Execute(batchSql, batch);
                            batch.Clear();
                        }
                    }

                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return result;
        }
    }
}