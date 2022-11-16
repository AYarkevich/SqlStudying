using System;

namespace Common;

public static class ConnectionsHelper
{
    public static string GetConnectionString(this DatabaseTypes databaseType)
    {
        return GetSystemVariableName(databaseType);
    }

    public static string GetSystemVariableName(Enum target)
    {
        var variableKey = target.GetAttribute<SystemVariableAttribute>().Name;
        var variableValue = GetSystemVariable(variableKey);

        if (string.IsNullOrEmpty(variableValue))
        {
            throw new NullReferenceException($"System variable {target.ToString()} was not found");
        }

        return variableValue;
    }

    public static string? GetSystemVariable(string key)
    {
        return Environment.GetEnvironmentVariable(key, EnvironmentVariableTarget.User);
    }
}