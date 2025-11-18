using Tyuiu.ZheleznyakDN.Sprint2.Task0.V5.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint2.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;

            bool[] res;
            res = ds.GetCompareOperations(x, y);

            bool[] wait = new bool[5] { false, true, true, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
