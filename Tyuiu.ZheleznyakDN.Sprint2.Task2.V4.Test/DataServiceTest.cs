using Tyuiu.ZheleznyakDN.Sprint2.Task2.V4.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 2;

            bool expected = true;

            bool result = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(expected, result);
        }
    }
}
