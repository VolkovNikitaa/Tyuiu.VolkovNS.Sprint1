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
            int value=14, valueTwo= 32;
            var res = ds.ConvertHoursMinutesToSeconds(value, valueTwo);
            Assert.AreEqual(52320, res);
        }
    }
}
