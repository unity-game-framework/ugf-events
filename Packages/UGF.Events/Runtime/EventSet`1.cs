using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet<TArguments> : EventCollection<HashSet<EventFunctionHandler<TArguments>>, TArguments>
    {
        private readonly HashSet<EventFunctionHandler<TArguments>> m_invoke = new HashSet<EventFunctionHandler<TArguments>>();

        public EventSet() : this(new HashSet<EventFunctionHandler<TArguments>>())
        {
        }

        public EventSet(HashSet<EventFunctionHandler<TArguments>> collection) : base(collection)
        {
        }

        protected override void OnInvoke(TArguments arguments)
        {
            foreach (EventFunctionHandler<TArguments> handler in Collection)
            {
                m_invoke.Add(handler);
            }

            foreach (EventFunctionHandler<TArguments> handler in m_invoke)
            {
                handler.Invoke(arguments);
            }

            m_invoke.Clear();
        }
    }
}
