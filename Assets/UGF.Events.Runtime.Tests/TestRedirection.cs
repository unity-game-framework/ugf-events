namespace UGF.Events.Runtime.Tests
{
    public class TestRedirection
    {
        public void Test()
        {
            var dispatcher1 = new EventDispatcher<int>(this);
            var dispatcher2 = new EventDispatcher<string>(this);

            dispatcher1.AddRedirection(dispatcher2, (_, _, arguments) => int.Parse(arguments));
        }
    }
}
