using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventList<TArguments> : EventCollection<TArguments>
    {
        private readonly List<Delegate> m_handlers;
        private readonly List<Delegate> m_invoke = new List<Delegate>();

        public EventList() : base(new List<Delegate>())
        {
            m_handlers = (List<Delegate>)Handlers;
        }

        protected override void OnInvoke(TArguments arguments)
        {
            foreach (Delegate handler in m_handlers)
            {
                m_invoke.Add(handler);
            }

            object argumentsBoxed = null;

            foreach (Delegate handler in m_invoke)
            {
                switch (handler)
                {
                    case EventHandler handlerObject:
                    {
                        argumentsBoxed ??= arguments;

                        handlerObject(argumentsBoxed);
                        break;
                    }
                    case EventHandler<TArguments> handlerTyped:
                    {
                        handlerTyped(arguments);
                        break;
                    }
                }
            }

            m_invoke.Clear();
        }
    }
}
