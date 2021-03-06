﻿#region Copyright 2014 Exceptionless

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// 
//     http://www.apache.org/licenses/LICENSE-2.0

#endregion

using System;
using Exceptionless.Logging;

namespace Exceptionless {
    internal class DefaultLastErrorIdManager : ILastErrorIdManager {
        private string _lastErrorId;

        /// <summary>
        ///     Gets the last error id that was submitted to the server.
        /// </summary>
        /// <returns>The error id</returns>
        public string GetLast() {
            return _lastErrorId;
        }

        /// <summary>
        ///     Clears the last error id.
        /// </summary>
        public void ClearLast() {
            _lastErrorId = String.Empty;
        }

        public void SetLast(string errorId) {
            _lastErrorId = errorId;
        }

        /// <summary>
        ///     The log accessor used for diagnostic information.
        /// </summary>
        public IExceptionlessLogAccessor LogAccessor { get; set; }
    }
}