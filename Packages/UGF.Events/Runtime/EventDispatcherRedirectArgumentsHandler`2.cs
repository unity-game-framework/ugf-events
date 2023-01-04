namespace UGF.Events.Runtime
{
    public delegate TTargetArguments EventDispatcherRedirectArgumentsHandler<TSourceArguments, TTargetArguments>(IEventDispatcher<TSourceArguments> source, IEventDispatcher<TTargetArguments> target, TSourceArguments arguments);
}
