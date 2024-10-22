using Tyuiu.MolchankinaAP.Sprint2.Task3.V19.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = 32.594;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.556;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -4;
            double res = ds.Calculate(x);
            double wait = 0.785;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = -329.967;
            Assert.AreEqual(wait, res);
        }
    }
}