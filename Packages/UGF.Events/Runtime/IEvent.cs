namespace UGF.Events.Runtime
{
    public interface IEvent
    {
        int Count { get; }

        void Add(EventHandler handler);
        bool Remove(EventHandler handler);
        void Invoke(object arguments);
        void Clear();
    }
}
