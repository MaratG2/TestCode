using System;

namespace MaratG2.Extensions
{
    public static class UnityExceptions
    {
        public static string CreateException(Exception exception, string additionalMessage = "")
        {
            if (string.IsNullOrWhiteSpace(additionalMessage))
                return exception.ToString();
            return exception + $": {additionalMessage}";
        }
    }
}