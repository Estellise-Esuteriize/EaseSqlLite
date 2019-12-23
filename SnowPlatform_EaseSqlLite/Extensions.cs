using SnowPlatform_EaseSqlLite.Constant;
using SnowPlatform_EaseSqlLite.Exceptions;
using SnowPlatform_EaseSqlLite.Strings;
using static System.Char;

namespace SnowPlatform_EaseSqlLite
{
    public static class Extensions
    {
        // ReSharper disable once MethodOverloadWithOptionalParameter
        public static string ToMessage(this EaseSqlLiteErrorCode code, string additional)
        {
            if (additional == null)
                throw new EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode.NullArgument);

            return string.IsNullOrWhiteSpace(additional)
                ? EaseSqlLiteErrors.ConvertToMessage(code)
                : EaseSqlLiteErrors.ConvertToMessage(code, additional);
        }

        public static string ToMessage(this EaseSqlLiteErrorCode code, params string[] additional)
        {
            return additional == null ? EaseSqlLiteErrors.ConvertToMessage(code) : EaseSqlLiteErrors.ConvertToMessage(code, additional);
        }
        
        public static string ReplaceSymbol(this string str, string symbol, string replacement)
        {
            if(EaseSqlLiteString.StringsHasNull(str, symbol, replacement))
                throw new EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode.NullArgument);
            
            return str.Replace(symbol, replacement);
        }

        public static string RemoveSymbol(this string str, string symbol)
        {
            
            if(EaseSqlLiteString.StringsHasNull(str, symbol))
                throw new EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode.NullArgument);
            
            return str.Replace(symbol, "").RemoveExtraWhiteSpace();
        }

        public static string RemoveExtraWhiteSpace(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode.NullArgument);

            if (str.HasExtraWhiteSpace())
                return str.Remove(str.Length - 1).RemoveExtraWhiteSpace();
            
            return str;
        }

        public static string Append(this string str, params string[] additionals)
        {
            if (additionals.Length <= 0)
                return str;

            if (EaseSqlLiteString.StringsHasNull(additionals))
                throw new EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode.NullArgument);

            return EaseSqlLiteString.Append(str, additionals);
        }

        public static bool HasExtraWhiteSpace(this string str)
        {
            if(string.IsNullOrWhiteSpace(str))
                throw new EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode.NullArgument);
            
            return IsWhiteSpace(str[str.Length - 1]);
        }
    }
}