namespace UGF.Events.Runtime
{
    public delegate void EventHandler<in TArguments>(TArguments arguments);
}
