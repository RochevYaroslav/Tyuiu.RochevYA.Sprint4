using Tyuiu.RochevYA.Sprint4.Task0.V20.Lib;
namespace Tyuiu.RochevYA.Sprint4.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Assert.AreEqual(24576, ds.GetMultEvenArrEl(array));
        }
    }
}
