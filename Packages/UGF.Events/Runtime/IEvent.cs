namespace UGF.Events.Runtime
{
    public interface IEvent : IEventDynamic
    {
        void Add(EventHandler handler);
        bool Remove(EventHandler handler);
        void Invoke();
    }
}
