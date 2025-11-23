using Tyuiu.ZheleznyakDN.Sprint2.Task5.V13.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string result = ds.FindDateOfNextDay(2024, 5, 15);
            Assert.AreEqual("16.05.2024", result);
        }
    }
}
