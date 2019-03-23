﻿namespace NsqCli.Core
{
    /// <summary>
    /// Logger interface.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Writes the output for a logging event.
        /// </summary>
        void Output(LogLevel logLevel, string message);

        /// <summary>
        /// Flushes the output stream.
        /// </summary>
        void Flush();
    }
}
