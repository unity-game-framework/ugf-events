using NUnit.Framework;

namespace UGF.Events.Runtime.Tests
{
    public class TestEvents
    {
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
    }
}
