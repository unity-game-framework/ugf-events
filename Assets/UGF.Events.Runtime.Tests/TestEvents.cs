using NUnit.Framework;
using Unity.Profiling;

namespace UGF.Events.Runtime.Tests
{
    public class TestEvents
    {
        private ProfilerMarker m_marker = new ProfilerMarker("TestEvents.InvokeMultiple");
        private ProfilerMarker m_marker2 = new ProfilerMarker("TestEvents.InvokeMultiple2");
        private Event m_event = new EventList();

        private class Target
        {
            public int Count { get; private set; }

            public void OnHandle((int first, float second) arguments)
            {
                Count++;
            }
        }

        [Test]
        public void Invoke()
        {
            var target = new Target();
            var event0 = new EventSet<(int first, float second)>();
            EventFunctionHandler<(int first, float second)> handler = target.OnHandle;

            event0.Add(handler);
            event0.Invoke((10, 10.5F));

            Assert.AreEqual(1, target.Count);
        }

        [Test]
        public void InvokeMultiple()
        {
            for (int i = 0; i < 1000; i++)
            {
                m_event.Add(() => { });
            }

            m_marker.Begin();
            m_event.Invoke();
            m_marker.End();

            m_marker2.Begin();
            m_event.Invoke();
            m_marker2.End();
        }
    }
}
