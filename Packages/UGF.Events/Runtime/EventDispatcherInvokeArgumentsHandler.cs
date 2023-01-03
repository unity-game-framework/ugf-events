namespace UGF.Events.Runtime
{
    public delegate void EventDispatcherInvokeArgumentsHandler<TArguments>(IEventDispatcher<TArguments> dispatcher, IEventDispatcherInvokeHandler handler, TArguments arguments);
}
