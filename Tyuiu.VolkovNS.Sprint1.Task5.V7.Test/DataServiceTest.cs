using Tyuiu.VolkovNS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.VolkovNS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f=96;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(3, res);
        }
    }
}
