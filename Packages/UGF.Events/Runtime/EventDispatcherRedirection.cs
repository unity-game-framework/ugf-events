using System;
using UGF.Initialize.Runtime;

namespace UGF.Events.Runtime
{
    public class EventDispatcherRedirection<TArguments> : Initializable
    {
        public IEventDispatcher<TArguments> Source { get; }
        public IEventDispatcher<TArguments> Target { get; }
        public EventDispatcherRedirectArgumentsHandler<TArguments> Handler { get; }

        public EventDispatcherRedirection(IEventDispatcher<TArguments> source, IEventDispatcher<TArguments> target, EventDispatcherRedirectArgumentsHandler<TArguments> handler)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
            Target = target ?? throw new ArgumentNullException(nameof(target));
            Handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();

            Source.Invoked += OnInvoked;
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            Source.Invoked -= OnInvoked;
        }

        private void OnInvoked(IEventDispatcher<TArguments> dispatcher, IEventDispatcherInvokeHandler handler, TArguments arguments)
        {
            Target.Invoke(handler, Handler.Invoke(Source, Target, arguments));
        }
    }
}
