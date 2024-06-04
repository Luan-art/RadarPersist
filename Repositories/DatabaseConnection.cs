using Microsoft.Data.SqlClient;

namespace Repositories
{
    public class DatabaseConnection
    {
        private static readonly Lazy<SqlConnection> _instance = new Lazy<SqlConnection>(() =>
        {
            string connectionString = "Data Source=127.0.0.1; Initial Catalog=DBRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=Yes;";
            return new SqlConnection(connectionString);
        });

        public static SqlConnection Instance => _instance.Value;

        private DatabaseConnection() { }
    }
}
