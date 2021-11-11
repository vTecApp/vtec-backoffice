using System.Data.SqlClient;

namespace VerticalTec.Shared
{
    public enum DbType
    {
        SqlServer = 1,
        MySQL = 2
    }

    public class DbConfig
    {
        public const string Database = "Database";

        public string Server { get; set; }
        public string Name { get; set; }
        public uint Port { get; set; } = 3308;
        public DbType DbType { get; set; }

        public string ConnectionString
        {
            get
            {
                var builder = new SqlConnectionStringBuilder();
                builder["Server"] = Server;
                builder.InitialCatalog = Name;
                builder.UserID = "vtecPOS";
                return builder.ConnectionString;
            }
        }
    }
}
