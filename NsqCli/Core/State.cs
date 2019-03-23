﻿namespace NsqCli.Core
{
    // https://github.com/nsqio/go-nsq/blob/master/states.go

    /// <summary>
    /// States
    /// </summary>
    public enum State
    {
        /// <summary>Init</summary>
        Init = 0,

        /// <summary>Disconnected</summary>
        Disconnected = 1,

        /// <summary>Connected</summary>
        Connected = 2,
    }
}
