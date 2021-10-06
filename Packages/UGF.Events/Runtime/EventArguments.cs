namespace UGF.Events.Runtime
{
    public class EventArguments : IEventArguments
    {
        public static EventArguments Empty { get; } = new EventArguments();
    }
}
