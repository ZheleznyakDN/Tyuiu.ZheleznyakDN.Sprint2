using Tyuiu.ZheleznyakDN.Sprint2.Task3.V9.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0;
            double result = ds.Calculate(x);
            Assert.AreEqual(1, result);
        }
    }
}
