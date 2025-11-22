using Tyuiu.ZheleznyakDN.Sprint2.Task4.V17.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double result = ds.Calculate(x, y);
            double expected = 5.12;

            Assert.AreEqual(expected, result);
        }
    }
}
