namespace UGF.Events.Runtime
{
    public interface IEvent
    {
        void Add(EventHandler handler);
        bool Remove(EventHandler handler);
        void Invoke(object arguments);
    }
}
