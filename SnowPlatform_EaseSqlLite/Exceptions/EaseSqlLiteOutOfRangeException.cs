namespace SnowPlatform_EaseSqlLite.Exceptions
{
    public class EaseSqlLiteOutOfRangeException : EaseSqlLiteExceptions
    {
        private readonly EaseSqlLiteErrorCode _code;
        private readonly string _additionalMessage;
        
        
        public EaseSqlLiteOutOfRangeException(EaseSqlLiteErrorCode code) : base(code)
        {
            _code = code;
        }

        public EaseSqlLiteOutOfRangeException(EaseSqlLiteErrorCode code, string additional)
        {
            _code = code;
            _additionalMessage = additional;
        }

        public override string ToString()
        {
            return _code.ToMessage(_additionalMessage);
        }
    }
}