namespace UGF.Events.Runtime
{
    public delegate void EventFunctionHandler<in TArguments>(TArguments arguments);
}
