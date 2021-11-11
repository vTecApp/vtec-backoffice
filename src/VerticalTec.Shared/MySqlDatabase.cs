using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

namespace VerticalTec.Shared
{
    public class MySqlDatabase : IDatabase
    {
        private readonly DbConfig _dbConfig;

        public MySqlDatabase(IOptions<DbConfig> options)
        {
            _dbConfig = options.Value;
        }

        public async Task<IDbConnection> ConnectAsync()
        {
            var conn = new MySqlConnection($"Port={_dbConfig.Port};Connection Timeout=28800;Allow User Variables=True;default command timeout=28800;UID=vtecPOS;PASSWORD=vtecpwnet;SERVER={_dbConfig.Server};DATABASE={_dbConfig.Name};old guids=true;");
            await conn.OpenAsync();
            return conn;
        }

        public IDataParameter CreateDataParameter(string name, object value)
        {
            return new MySqlParameter(name, value);
        }

        public Task ExecuteNonQueryAsync(IDbConnection conn, string cmdText)
        {
            var cmd = CreateCommand(conn, cmdText);
            return cmd.ExecuteNonQueryAsync();
        }

        public Task ExecuteNonQueryAsync(IDbConnection conn, string cmdText, params IDataParameter[] dataParameters)
        {
            var cmd = CreateCommand(conn, cmdText, dataParameters);
            return cmd.ExecuteNonQueryAsync();
        }

        public async Task<IDataReader> ExecuteReaderAsync(IDbConnection conn, string cmdText)
        {
            var cmd = CreateCommand(conn, cmdText);
            return await cmd.ExecuteReaderAsync();
        }

        public async Task<IDataReader> ExecuteReaderAsync(IDbConnection conn, string cmdText, params IDataParameter[] dataParameters)
        {
            var cmd = CreateCommand(conn, cmdText, dataParameters);
            return await cmd.ExecuteReaderAsync();
        }

        public Task<object> ExecuteScalarAsync(IDbConnection conn, string cmdText)
        {
            var cmd = CreateCommand(conn, cmdText);
            return cmd.ExecuteScalarAsync();
        }

        public Task<object> ExecuteScalarAsync(IDbConnection conn, string cmdText, params IDataParameter[] dataParameters)
        {
            var cmd = CreateCommand(conn, cmdText, dataParameters);
            return cmd.ExecuteScalarAsync();
        }

        private MySqlCommand CreateCommand(IDbConnection conn, string cmdText, IDataParameter[] dataParameters = default)
        {
            var cmd = new MySqlCommand(cmdText, conn as MySqlConnection);
            if (dataParameters?.Length > 0)
            {
                foreach (var param in dataParameters)
                {
                    cmd.Parameters.Add(param);
                }
            }
            return cmd;
        }
    }
}
