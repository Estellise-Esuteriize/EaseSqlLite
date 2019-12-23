namespace SnowPlatform_EaseSqlLite.Exceptions
{
    public class EaseSqlLiteNullArgumentException : EaseSqlLiteExceptions
    {
        private readonly EaseSqlLiteErrorCode _code;

        public EaseSqlLiteNullArgumentException(EaseSqlLiteErrorCode code) : base(code)
        {
            _code = code;
        }

        public override string ToString()
        {
            return _code.ToMessage();
        }
    }
}