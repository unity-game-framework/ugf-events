using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventList : EventCollection<List<EventFunctionHandler>>
    {
        private readonly List<EventFunctionHandler> m_invoke = new List<EventFunctionHandler>();

        public EventList(int capacity = 4) : this(new List<EventFunctionHandler>(capacity))
        {
        }

        public EventList(List<EventFunctionHandler> collection) : base(collection)
        {
        }

        protected override void OnInvoke()
        {
            for (int i = 0; i < Collection.Count; i++)
            {
                m_invoke.Add(Collection[i]);
            }

            for (int i = 0; i < m_invoke.Count; i++)
            {
                m_invoke[i].Invoke();
            }

            m_invoke.Clear();
        }
    }
}
