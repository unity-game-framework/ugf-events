namespace UGF.Events.Runtime
{
    public interface IEvent<out TArguments>
    {
        void Add(EventHandler<TArguments> handler);
        bool Remove(EventHandler<TArguments> handler);
    }
}
