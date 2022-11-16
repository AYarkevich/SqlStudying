using System;

namespace Common;

public class SystemVariableAttribute : Attribute
{
    public SystemVariableAttribute(string name)
    {
        Name = name;
    }
    public string Name { get; }
}