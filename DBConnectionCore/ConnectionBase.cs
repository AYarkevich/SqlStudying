using Common;

namespace DBConnectionCore;

public abstract class ConnectionBase
{
    public abstract DatabaseTypes DbType { get; }
    public abstract string GetConnectionState();

    protected string ConnectionString => DbType.GetConnectionString();
}