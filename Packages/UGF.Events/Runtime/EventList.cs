using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventList : EventCollection<List<EventFunctionHandler>>
    {
        private readonly List<EventFunctionHandler> m_invoke;

        public EventList(int capacity = 4) : this(new List<EventFunctionHandler>(capacity))
        {
            m_invoke = new List<EventFunctionHandler>(Collection.Capacity);
        }

        public EventList(List<EventFunctionHandler> collection) : base(collection)
        {
            m_invoke = new List<EventFunctionHandler>(Collection.Capacity);
        }

        protected override void OnInvoke()
        {
            m_invoke.AddRange(Collection);

            try
            {
                for (int i = 0; i < m_invoke.Count; i++)
                {
                    m_invoke[i].Invoke();
                }
            }
            finally
            {
                m_invoke.Clear();
            }
        }
    }
}
