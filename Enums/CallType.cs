using System;

namespace Solidex.Core.Base.Enums
{
    [Flags]
    public enum CallType
    {
        Incoming, Outcoming, Missed,
    }
}