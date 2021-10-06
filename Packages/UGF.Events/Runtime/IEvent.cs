namespace UGF.Events.Runtime
{
    public interface IEvent : IEventDynamic
    {
        void Add(EventFunctionHandler handler);
        bool Remove(EventFunctionHandler handler);
        void Invoke();
    }
}
