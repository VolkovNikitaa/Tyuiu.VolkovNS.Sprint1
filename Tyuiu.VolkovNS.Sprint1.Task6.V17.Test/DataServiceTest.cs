using Tyuiu.VolkovNS.Sprint1.Task6.V17.Lib;

namespace Tyuiu.VolkovNS.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "aabbaa";
            Assert.IsTrue(ds.CheckPalindrome(value));
        }
    }
}
