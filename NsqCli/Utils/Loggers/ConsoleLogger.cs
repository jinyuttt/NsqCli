﻿using System;
using System.Diagnostics;
using System.IO;
using NsqCli.Core;

namespace NsqCli.Utils.Loggers
{
    /// <summary>
    /// Console logger
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        private readonly TextWriter _textWriter;
        private readonly LogLevel _minLogLevel;
        private readonly object _textWriterLocker = new object();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger"/> class.
        /// </summary>
        /// <param name="minLogLevel">The minimum <see cref="LogLevel"/> to output.</param>
        public ConsoleLogger(LogLevel minLogLevel)
        {
            _textWriter = new StreamWriter(Console.OpenStandardError());
            _minLogLevel = minLogLevel;
        }

        /// <summary>
        /// Writes the output for a logging event.
        /// </summary>
        public void Output(LogLevel logLevel, string message)
        {
            if (logLevel < _minLogLevel)
                return;

            // TODO: proper width formatting on log level
            message = string.Format("[{0}] {1}", Log.Prefix(logLevel), message);

            lock (_textWriterLocker)
            {
                _textWriter.WriteLine(message);
                _textWriter.Flush();
            }
            Debug.WriteLine(message);
        }

        /// <summary>
        /// Flushes the output stream.
        /// </summary>
        public void Flush()
        {
            lock (_textWriterLocker)
            {
                _textWriter.Flush();
            }
        }
    }
}
