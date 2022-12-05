using System;
using UnityEngine;

namespace MaratG2.Extensions
{
    public static class UnityExceptions
    {
        private static readonly ILoggable _loggable = new UnityLoggable();
        private static string _tag = "Unity Exceptions";
        public static void Raise(Exception exception, string additionalMessage = "")
        {
            if (string.IsNullOrWhiteSpace(additionalMessage))
                LogException(exception.ToString());
            LogException(exception + $": {additionalMessage}");
        }
        public static void RaiseTagged(Exception exception, string additionalMessage = "")
        {
            if (string.IsNullOrWhiteSpace(additionalMessage))
                LogException($"{_tag}: " + exception);
            LogException($"{_tag}: " + exception + $": {additionalMessage}");
        }

        private static void LogException(string text)
        {
            _loggable.LogError(text);
        }
    }
}