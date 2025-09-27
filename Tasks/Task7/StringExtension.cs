using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task7
{
    internal static class StringExtension
    {
        public static string ToJSON<T>(this T obj)
        {
            if (obj == null) throw new ArgumentNullException(nameof(obj));
            return JsonSerializer.Serialize(obj);
        }

    }
}
