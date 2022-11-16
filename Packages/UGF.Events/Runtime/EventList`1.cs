using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventList<TArguments> : EventCollection<List<EventFunctionHandler<TArguments>>, TArguments>
    {
        private readonly List<EventFunctionHandler<TArguments>> m_invoke;

        public EventList(int capacity = 4) : this(new List<EventFunctionHandler<TArguments>>(capacity))
        {
            m_invoke = new List<EventFunctionHandler<TArguments>>(Collection.Capacity);
        }

        public EventList(List<EventFunctionHandler<TArguments>> collection) : base(collection)
        {
            m_invoke = new List<EventFunctionHandler<TArguments>>(Collection.Capacity);
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
