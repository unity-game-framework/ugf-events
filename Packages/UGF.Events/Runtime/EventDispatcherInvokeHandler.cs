namespace UGF.Events.Runtime
{
    public class EventDispatcherInvokeHandler : IEventDispatcherInvokeHandler
    {
        public bool IsCompleted { get; private set; }

        public void Complete()
        {
            IsCompleted = true;
        }
    }
}
