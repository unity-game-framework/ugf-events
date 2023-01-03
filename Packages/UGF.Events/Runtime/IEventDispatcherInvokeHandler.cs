namespace UGF.Events.Runtime
{
    public interface IEventDispatcherInvokeHandler
    {
        bool IsCompleted { get; }

        void Complete();
    }
}
