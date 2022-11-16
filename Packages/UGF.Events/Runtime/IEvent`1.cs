namespace UGF.Events.Runtime
{
    public interface IEvent<out TArguments> : IEventDynamic
    {
        void Add(EventFunctionHandler<TArguments> handler);
        bool Remove(EventFunctionHandler<TArguments> handler);
    }
}
