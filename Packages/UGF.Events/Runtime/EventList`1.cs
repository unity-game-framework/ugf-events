using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventList<TArguments> : EventCollection<List<EventFunctionHandler<TArguments>>, TArguments>
    {
        private readonly List<EventFunctionHandler<TArguments>> m_invoke = new List<EventFunctionHandler<TArguments>>();

        public EventList(int capacity = 4) : this(new List<EventFunctionHandler<TArguments>>(capacity))
        {
        }

        public EventList(List<EventFunctionHandler<TArguments>> collection) : base(collection)
        {
        }

        protected override void OnInvoke(TArguments arguments)
        {
            for (int i = 0; i < Collection.Count; i++)
            {
                m_invoke.Add(Collection[i]);
            }

            for (int i = 0; i < m_invoke.Count; i++)
            {
                m_invoke[i].Invoke(arguments);
            }

            m_invoke.Clear();
        }
    }
}
