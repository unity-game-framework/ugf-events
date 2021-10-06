using System;

namespace UGF.Events.Runtime
{
    public static class EventExtensions
    {
        public static void InvokeEmpty(this EventDynamic eventDynamic)
        {
            if (eventDynamic == null) throw new ArgumentNullException(nameof(eventDynamic));

            eventDynamic.Invoke(EventArguments.Empty);
        }
    }
}
