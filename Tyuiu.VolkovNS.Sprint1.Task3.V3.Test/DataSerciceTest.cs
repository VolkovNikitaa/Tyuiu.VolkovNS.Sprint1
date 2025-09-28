using Tyuiu.VolkovNS.Sprint1.Task3.V3.Lib;
namespace Tyuiu.VolkovNS.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataSerciceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double lenght = 9, width = 7.5, height = 5;
            var res = ds.ParallelepipedVolume(lenght,width,height);
            Assert.AreEqual(337.5, res);
        }
    }
}
