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

        public static EventDispatcherRedirection<T> AddRedirection<T>(this EventDispatcher<T> dispatcher, IEventDispatcher<T> source, EventDispatcherRedirectArgumentsHandler<T> handler)
        {
            if (dispatcher == null) throw new ArgumentNullException(nameof(dispatcher));

            return dispatcher.Children.Create(new EventDispatcherRedirection<T>(source, dispatcher, handler));
        }
    }
}
