using System;

namespace UGF.Events.Runtime
{
    public class EventArgumentsUnknownException : Exception
    {
        public EventArgumentsUnknownException(IEventArguments arguments) : base($"Event arguments type is unknown: '{arguments}'.")
        {
        }
    }
}
