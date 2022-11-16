using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet<TArguments> : EventCollection<HashSet<EventFunctionHandler<TArguments>>, TArguments>
    {
        private readonly List<EventFunctionHandler<TArguments>> m_invoke;

        public EventSet(int capacity = 4) : this(new HashSet<EventFunctionHandler<TArguments>>(capacity))
        {
            m_invoke = new List<EventFunctionHandler<TArguments>>(capacity);
        }

        public EventSet(HashSet<EventFunctionHandler<TArguments>> collection) : base(collection)
        {
            m_invoke = new List<EventFunctionHandler<TArguments>>(collection.Count);
        }

        protected override void OnInvoke(TArguments arguments)
        {
            m_invoke.AddRange(Collection);

            try
            {
                for (int i = 0; i < m_invoke.Count; i++)
                {
                    m_invoke[i].Invoke(arguments);
                }
            }
            finally
            {
                m_invoke.Clear();
            }
        }
    }
}
