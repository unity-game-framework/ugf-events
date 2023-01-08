namespace UGF.Events.Runtime.Tests
{
    public class TestRedirection
    {
        public void Test()
        {
            var dispatcher1 = new EventDispatcher<int>(this);
            var dispatcher2 = new EventDispatcher<string>(this);

            dispatcher1.AddRedirection(dispatcher2, (_, _, arguments) => int.Parse(arguments));
            dispatcher1.AddRedirection(dispatcher1, (_, _, arguments) => 0);
            dispatcher1.AddRedirection(dispatcher2, (_, _, arguments) => 0);
            dispatcher2.AddRedirection(dispatcher1, (_, _, arguments) => "");
            dispatcher2.AddRedirection(dispatcher2, (_, _, arguments) => "");
        }
    }
}
