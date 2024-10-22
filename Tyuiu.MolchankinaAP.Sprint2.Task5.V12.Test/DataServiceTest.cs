using Tyuiu.MolchankinaAP.Sprint2.Task5.V12.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            int g, m, n;
            g = 1997;
            m = 1;
            n = 1;

            Assert.AreEqual("31.12.1996", ds.FindDateOfPreviousDay(g, m, n));
        }
    }
}