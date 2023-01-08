using System;
using UGF.Initialize.Runtime;

namespace UGF.Events.Runtime
{
    public class EventDispatcherRedirection<TSourceArguments, TTargetArguments> : Initializable
    {
        public IEventDispatcher<TSourceArguments> Source { get; }
        public IEventDispatcher<TTargetArguments> Target { get; }
        public EventDispatcherRedirectArgumentsHandler<TSourceArguments, TTargetArguments> Handler { get; }

        public EventDispatcherRedirection(IEventDispatcher<TSourceArguments> source, IEventDispatcher<TTargetArguments> target, EventDispatcherRedirectArgumentsHandler<TSourceArguments, TTargetArguments> handler)
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

        private void OnInvoked(IEventDispatcher<TSourceArguments> dispatcher, IEventDispatcherInvokeHandler handler, TSourceArguments arguments)
        {
            Target.Invoke(handler, Handler.Invoke(Source, Target, arguments));
        }
    }
}
