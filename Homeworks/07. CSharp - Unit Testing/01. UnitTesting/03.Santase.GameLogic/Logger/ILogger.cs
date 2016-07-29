namespace _03.Santase.GameLogic.Logger
{
    using System;

    public interface ILogger : IDisposable
    {
        void Log(string message);

        void LogLine(string message);
    }
}
