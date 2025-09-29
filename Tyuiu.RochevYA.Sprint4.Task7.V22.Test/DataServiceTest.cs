using Tyuiu.RochevYA.Sprint4.Task7.V22.Lib;
namespace Tyuiu.RochevYA.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(9216, ds.Calculate(5,3,"695324951753684"));
        }
    }
}
