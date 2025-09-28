using Tyuiu.VolkovNS.Sprint1.Task7.V28.Lib;

namespace Tyuiu.VolkovNS.Sprint1.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x=1, y=2, wait = 3;
            Assert.AreEqual(wait,ds.Calculate(x,y));
        }
    }
}
