using Common;
using Npgsql;

namespace DBConnectionCore;

public class PostgresConnectionBase : ConnectionBase
{
    public override DatabaseTypes DbType => DatabaseTypes.PostgresSql;

    public override string GetConnectionState()
    {
        using var conn = new NpgsqlConnection(ConnectionString);
        conn.Open();
        return conn.State.ToString();
    }
}