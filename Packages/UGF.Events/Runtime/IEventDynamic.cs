using System;

namespace UGF.Events.Runtime
{
    public interface IEventDynamic
    {
        void Add(Delegate handler);
        bool Remove(Delegate handler);
        void Invoke(object arguments);
    }
}
