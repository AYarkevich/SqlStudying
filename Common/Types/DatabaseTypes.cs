namespace Common;

public enum DatabaseTypes
{
    [SystemVariable("SqlConnectionString")]
    MsSql,
    
    [SystemVariable("PostgresConnectionString")]
    PostgresSql
}