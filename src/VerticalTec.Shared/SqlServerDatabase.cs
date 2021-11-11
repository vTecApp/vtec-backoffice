using Microsoft.Extensions.Options;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace VerticalTec.Shared
{
    public class SqlServerDatabase : IDatabase
    {
        private readonly DbConfig _dbConfig;

        public SqlServerDatabase(IOptions<DbConfig> options)
        {
            _dbConfig = options.Value;
        }

        public async Task<IDbConnection> ConnectAsync()
        {
            var conn = new SqlConnection($"Data Source={_dbConfig.Server}; Initial Catalog={_dbConfig.Name};User ID=vtecPOS; Password=vtecpwnet");
            await conn.OpenAsync();
            return conn;
        }

        public IDataParameter CreateDataParameter(string name, object value)
        {
            return new SqlParameter(name, value);
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

        private SqlCommand CreateCommand(IDbConnection conn, string cmdText, IDataParameter[] dataParameters = default)
        {
            var cmd = new SqlCommand(cmdText, conn as SqlConnection);
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
