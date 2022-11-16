using System;
using System.Collections.Generic;
using System.Linq;

namespace Common;

public static class EnumExtensions
{
    public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this Enum value)
        where TAttribute : Attribute
    {
        var enumType = value.GetType();
        var name = Enum.GetName(enumType, value);
        return (string.IsNullOrEmpty(name)
                   ? null
                   : enumType.GetField(name)?.GetCustomAttributes(false).OfType<TAttribute>()) ??
               throw new InvalidOperationException();
    }

    public static TAttribute GetAttribute<TAttribute>(this Enum value)
        where TAttribute : Attribute
    {
        return value.GetAttributes<TAttribute>().FirstOrDefault() ?? throw new InvalidOperationException();
    }
}