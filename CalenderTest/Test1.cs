using Calender;

namespace CalenderTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Day day = new Day();
            day.MakeNextDay();
        }
    }
}
