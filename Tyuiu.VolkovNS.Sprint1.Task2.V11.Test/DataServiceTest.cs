using Tyuiu.VolkovNS.Sprint1.Task2.V11.Lib;
namespace Tyuiu.VolkovNS.Sprint1.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x=14, y= 32;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(52320, res);
        }
    }
}
