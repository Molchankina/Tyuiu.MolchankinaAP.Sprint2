using Tyuiu.MolchankinaAP.Sprint2.Task6.V15.Lib;
namespace Tyuiu.MolchankinaAP.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService service1 = new DataService();
            int k = 251;
            Assert.AreEqual("Суббота", service1.FindDayName(k));
        }
    }
}