namespace UGF.Events.Runtime
{
    public delegate TArguments EventDispatcherRedirectArgumentsHandler<TArguments>(IEventDispatcher<TArguments> source, IEventDispatcher<TArguments> target, TArguments arguments);
}
