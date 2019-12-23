using System;
using System.Data.SQLite;
using SnowPlatform_EaseSqlLite.Constant;

namespace SnowPlatform_EaseSqlLite.Exceptions
{
    public class EaseSqlLiteErrors
    {

        internal static string ConvertToMessage(EaseSqlLiteErrorCode code)
        {
            return ConvertinCode(code);
        }

        internal static string ConvertToMessage(EaseSqlLiteErrorCode code, string additional)
        {
            return ConvertinCode(code).Append(additional);
        }

        internal static string ConvertToMessage(EaseSqlLiteErrorCode code, params string[] additional)
        {
            return ConvertinCode(code).Append(additional);
        }

        internal static string ConvertinCode(EaseSqlLiteErrorCode code)
        {
            switch (code)
            {
                case EaseSqlLiteErrorCode.UnknownError:
                    return ConstantString.UnknownError;
                case EaseSqlLiteErrorCode.InvalidPath:
                    return ConstantString.InvalidDatabasePathError;
                case EaseSqlLiteErrorCode.InvalidName:
                    return ConstantString.InvalidNameError;
                case EaseSqlLiteErrorCode.NullArgument:
                    return ConstantString.InvalidNullArgumentExceptionError;
                case EaseSqlLiteErrorCode.OutOfRange:
                    return ConstantString.InvalidOutOfRangeError;
                default:
                    throw new EaseSqlLiteOutOfRangeException(EaseSqlLiteErrorCode.OutOfRange, nameof(code));
            }
        }

    }

    public enum EaseSqlLiteErrorCode
    {
        UnknownError,
        InvalidPath,
        InvalidName,
        NullArgument,
        OutOfRange,
    }
}