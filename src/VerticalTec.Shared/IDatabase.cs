using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace VerticalTec.Shared
{
    public interface IDatabase
    {
        Task<IDbConnection> ConnectAsync();

        Task ExecuteNonQueryAsync(IDbConnection conn, string cmdText);

        Task ExecuteNonQueryAsync(IDbConnection conn, string cmdText, params IDataParameter[] dataParameters);

        Task<object> ExecuteScalarAsync(IDbConnection conn, string cmdText);

        Task<object> ExecuteScalarAsync(IDbConnection conn, string cmdText, params IDataParameter[] dataParameters);

        Task<IDataReader> ExecuteReaderAsync(IDbConnection conn, string cmdText);

        Task<IDataReader> ExecuteReaderAsync(IDbConnection conn, string cmdText, params IDataParameter[] dataParameters);

        IDataParameter CreateDataParameter(string name, object value);
    }
}
