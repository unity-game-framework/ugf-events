namespace UGF.Events.Runtime
{
    public interface IEvent<TArguments> : IEvent
    {
        void Add(EventHandler<TArguments> handler);
        bool Remove(EventHandler<TArguments> handler);
        void Invoke(TArguments arguments);
    }
}
