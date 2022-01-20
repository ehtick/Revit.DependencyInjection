﻿using System;
using System.Threading;

namespace Revit.DependencyInjection.Async
{
    internal class FuncTask
    {
        internal Delegate Action { get; set; }

        internal DelegateType DelegateType { get; set; }

        internal CancellationTokenSource Cancellation { get; set; }
    }
}