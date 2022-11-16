using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet : EventCollection<HashSet<EventFunctionHandler>>
    {
        private readonly List<EventFunctionHandler> m_invoke;

        public EventSet(int capacity = 4) : this(new HashSet<EventFunctionHandler>(capacity))
        {
            m_invoke = new List<EventFunctionHandler>(capacity);
        }

        public EventSet(HashSet<EventFunctionHandler> collection) : base(collection)
        {
            m_invoke = new List<EventFunctionHandler>(collection.Count);
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
