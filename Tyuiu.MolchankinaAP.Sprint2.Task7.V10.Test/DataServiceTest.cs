using Tyuiu.MolchankinaAP.Sprint2.Task7.V10.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task7.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}