using System;
using System.Collections;
using System.Threading.Tasks;
using UGF.Initialize.Runtime;

namespace UGF.Events.Runtime
{
    public static class EventDispatcherExtensions
    {
        public static async Task InvokeAsync<T>(this IEventDispatcher<T> dispatcher, T arguments)
        {
            if (dispatcher == null) throw new ArgumentNullException(nameof(dispatcher));

            await dispatcher.Invoke(arguments).WaitAsync();
        }

        public static IEnumerator InvokeRoutine<T>(this IEventDispatcher<T> dispatcher, T arguments)
        {
            if (dispatcher == null) throw new ArgumentNullException(nameof(dispatcher));

            yield return dispatcher.Invoke(arguments).WaitRoutine();
        }

        public static EventDispatcherRedirection<T1, T0> AddRedirection<T0, T1>(this EventDispatcher<T0> dispatcher, IEventDispatcher<T1> source, EventDispatcherRedirectArgumentsHandler<T1, T0> handler)
        {
            if (dispatcher == null) throw new ArgumentNullException(nameof(dispatcher));

            return dispatcher.Children.Create(new EventDispatcherRedirection<T1, T0>(source, dispatcher, handler));
        }
    }
}
