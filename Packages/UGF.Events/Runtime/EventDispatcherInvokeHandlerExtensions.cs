using System;
using System.Collections;
using System.Threading.Tasks;

namespace UGF.Events.Runtime
{
    public static class EventDispatcherInvokeHandlerExtensions
    {
        public static async Task WaitAsync(this IEventDispatcherInvokeHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            while (!handler.IsCompleted)
            {
                await Task.Yield();
            }
        }

        public static IEnumerator WaitRoutine(this IEventDispatcherInvokeHandler handler)
        {
            if (handler == null) throw new ArgumentNullException(nameof(handler));

            while (!handler.IsCompleted)
            {
                yield return null;
            }
        }
    }
}
