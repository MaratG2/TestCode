namespace MaratG2.Extensions
{
    public enum Exceptions
    {
        Exception,
        ArgumentException,
        ArgumentNullException,
        ArgumentOutOfRange,
        NullReferenceException
    }

    public static class UnityExceptions
    {
        public static string CreateException(Exceptions exception, string additionalMessage = "")
        {
            if (string.IsNullOrWhiteSpace(additionalMessage))
                return exception.ToString();
            return exception + $": {additionalMessage}";
        }
    }
}