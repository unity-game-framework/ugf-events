namespace UGF.Events.Runtime
{
    public interface IEvent<TArguments> : IEventDynamic
    {
        void Add(EventHandler<TArguments> handler);
        bool Remove(EventHandler<TArguments> handler);
        void Invoke(TArguments arguments);
    }
}
