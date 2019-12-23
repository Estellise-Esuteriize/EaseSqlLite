using System;
using System.Linq;
using System.Data.Sql;

namespace SnowPlatform_EaseSqlLite.Strings
{
    public class EaseSqlLiteString
    {
        internal static bool StringsHasNull(params string[] str)
        {
            return str.Length > 0 && str.Any(x => x == null);
        }

        internal static string Append(string str, params string[] additionals)
        {
            return additionals.Aggregate(str, (current, add) => current + $" {add}");
        }

    }
}