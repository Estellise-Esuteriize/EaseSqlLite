using System;

namespace SnowPlatform_EaseSqlLite.Exceptions
{
    public class EaseSqlLiteExceptions : Exception
    {


        public EaseSqlLiteExceptions()
        {
            
        }

        public EaseSqlLiteExceptions(string message) : base(message)
        {
            
        }

        public EaseSqlLiteExceptions(string message, EaseSqlLiteExceptions inner) : base(message, inner)
        {
            
        }
        public EaseSqlLiteExceptions(EaseSqlLiteErrorCode code) : base(code.ToMessage())
        {
            
        }

        public EaseSqlLiteExceptions(EaseSqlLiteErrorCode code, EaseSqlLiteExceptions inner) : base(
            code.ToMessage(), inner)
        {
            
        }

        public EaseSqlLiteExceptions(EaseSqlLiteErrorCode code, params string[] adds) : base(code.ToMessage(adds))
        {
            
        }

    }
}
