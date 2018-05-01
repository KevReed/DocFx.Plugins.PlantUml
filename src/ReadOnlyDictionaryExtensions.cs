using System;
using System.Collections.Generic;

namespace DocFx.Plugins.PlantUml
{
    internal static class ReadOnlyDictionaryExtensions
    {
        public static T GetValueOrDefault<T>(this IReadOnlyDictionary<string, object> collection, string key, T defaultValue)
        {
            if (collection.TryGetValue(key, out object value))
            {
                return (T)value;
            }

            return defaultValue;
        }

        public static T GetEnumOrDefault<T>(this IReadOnlyDictionary<string, object> collection, string key, T defaultValue) where T : struct, IConvertible
        {
            var enumType = typeof(T);
            var defaultName = Enum.GetName(enumType, defaultValue);
            var parameter = collection.GetValueOrDefault(key, defaultName);
            return (T)Enum.Parse(enumType, parameter, true);
        }
    }
}
