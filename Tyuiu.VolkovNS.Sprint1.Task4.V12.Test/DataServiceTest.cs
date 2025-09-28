using Tyuiu.VolkovNS.Sprint1.Task4.V12.Lib;

namespace Tyuiu.VolkovNS.Sprint1.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x=1,y=1;
            var res = Math.Round(ds.Calculate(x,y),3);
            Assert.AreEqual(0, res);
        }
    }
}
