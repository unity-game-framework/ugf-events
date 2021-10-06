using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet : EventCollection<HashSet<EventFunctionHandler>>
    {
        private readonly HashSet<EventFunctionHandler> m_invoke = new HashSet<EventFunctionHandler>();

        public EventSet() : this(new HashSet<EventFunctionHandler>())
        {
        }

        public EventSet(HashSet<EventFunctionHandler> collection) : base(collection)
        {
        }

        protected override void OnInvoke()
        {
            foreach (EventFunctionHandler handler in Collection)
            {
                m_invoke.Add(handler);
            }

            foreach (EventFunctionHandler handler in m_invoke)
            {
                handler.Invoke();
            }

            m_invoke.Clear();
        }
    }
}
