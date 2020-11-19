using System;
using System.Linq;
using System.Collections.Generic;

namespace System.Daemon.Utils
{
    public static class EnumUtils
    {
        public static IEnumerable<T> GetValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }

        public static T GetEnumValueByName<T>(string enumValue) where T : struct, IConvertible
        {
            return (T)Enum.Parse(typeof(T), enumValue);
        }
    }
}
