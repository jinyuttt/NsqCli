﻿using System;
using NsqCli.Core;

namespace NsqCli.Bus.Logging
{
    internal static class IMessageAuditorExtensions
    {
        public static void TryOnReceived(
            this IMessageAuditor messageAuditor,
            ILogger logger,
            IBus bus,
            MessageInformation messageInformation
        )
        {
            try
            {
                messageAuditor.OnReceived(bus, messageInformation);
            }
            catch (Exception ex)
            {
                logger.Output(LogLevel.Error, string.Format("messageAuditor.OnReceived - {0}", ex));
            }
        }

        public static void TryOnSucceeded(
            this IMessageAuditor messageAuditor,
            ILogger logger,
            IBus bus,
            MessageInformation messageInformation
        )
        {
            try
            {
                messageAuditor.OnSucceeded(bus, messageInformation);
            }
            catch (Exception ex)
            {
                logger.Output(LogLevel.Error, string.Format("messageAuditor.OnSucceeded - {0}", ex));
            }
        }

        public static void TryOnFailed(
            this IMessageAuditor messageAuditor,
            ILogger logger,
            IBus bus,
            FailedMessageInformation failedMessageInformation
        )
        {
            try
            {
                messageAuditor.OnFailed(bus, failedMessageInformation);
            }
            catch (Exception ex)
            {
                logger.Output(LogLevel.Error, string.Format("messageAuditor.OnFailed - {0}", ex));
            }
        }
    }
}
