using Tyuiu.ZheleznyakDN.Sprint2.Task7.V12.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool result = ds.CheckDotInShadedArea(0.5, 0.5);
            Assert.IsTrue(result);
        }
    }
}
