namespace UGF.Events.Runtime
{
    public interface IEvent<TArguments> : IEventDynamic
    {
        void Add(EventFunctionHandler<TArguments> handler);
        bool Remove(EventFunctionHandler<TArguments> handler);
        void Invoke(TArguments arguments);
    }
}
