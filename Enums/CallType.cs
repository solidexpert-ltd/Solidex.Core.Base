using System;

namespace Solidex.Core.ViewModels.Enums
{
    [Flags]
    public enum CallType
    {
        Incoming, Outcoming, Missed,
    }
}