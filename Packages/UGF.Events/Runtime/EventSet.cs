using System;
using System.Collections.Generic;

namespace UGF.Events.Runtime
{
    public class EventSet<TArguments> : EventCollection<TArguments>
    {
        private readonly HashSet<Delegate> m_handlers;
        private readonly HashSet<Delegate> m_invoke = new HashSet<Delegate>();

        public EventSet() : base(new HashSet<Delegate>())
        {
            m_handlers = (HashSet<Delegate>)Handlers;
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
