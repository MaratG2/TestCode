namespace MaratG2.Extensions
{
    interface ILoggable
    {
        void Log(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}