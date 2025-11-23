using Tyuiu.ZheleznyakDN.Sprint2.Task6.V14.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task6.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string result = ds.FindDayName(1, 1);
            Assert.AreEqual("понедельник", result);
        }
    }
}
