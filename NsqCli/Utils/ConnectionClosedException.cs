﻿using System;
using System.Runtime.Serialization;

namespace NsqCli.Utils
{
    /// <summary>
    /// Thrown when attempting to read or write from a closed <see cref="TcpConn"/>.
    /// </summary>
    [Serializable]
    public class ConnectionClosedException : Exception
    {
        private const string DefaultExceptionMessage = "Connection closed";

        /// <summary>Initializes a new instance of the <see cref="ConnectionClosedException"/> class.</summary>
        public ConnectionClosedException()
            : base(DefaultExceptionMessage)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ConnectionClosedException"/> class.</summary>
        /// <param name="message">The exception message.</param>
        public ConnectionClosedException(string message)
            : base(message)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ConnectionClosedException"/> class.</summary>
        /// <param name="message">The exception message.</param>
        ///  <param name="innerException">The exception that is the cause of the current exception.</param>
        public ConnectionClosedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ConnectionClosedException"/> class.</summary>
        ///  <param name="innerException">The exception that is the cause of the current exception.</param>
        public ConnectionClosedException(Exception innerException)
            : base(DefaultExceptionMessage, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionClosedException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about
        /// the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about
        /// the source or destination.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="info"/> parameter is null.</exception>
        /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult"/>
        /// is zero (0).</exception>
        protected ConnectionClosedException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
