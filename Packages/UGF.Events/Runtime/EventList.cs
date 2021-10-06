using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventList : EventCollection<List<EventHandler>>
    {
        private readonly List<EventHandler> m_invoke = new List<EventHandler>();

        public EventList(int capacity = 4) : this(new List<EventHandler>(capacity))
        {
        }

        public EventList(List<EventHandler> collection) : base(collection)
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
