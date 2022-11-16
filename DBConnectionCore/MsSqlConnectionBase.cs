using Common;
using Microsoft.Data.SqlClient;

namespace DBConnectionCore;

public class MsSqlConnectionBase : ConnectionBase
{
    public override DatabaseTypes DbType => DatabaseTypes.MsSql;

    public override string GetConnectionState()
    {
        using var conn = new SqlConnection(ConnectionString);
        conn.Open();
        return conn.State.ToString();
    }
}