using Tyuiu.RochevYA.Sprint4.Task4.V19.Lib;
namespace Tyuiu.RochevYA.Sprint4.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] { { 6, 7, 3, 5, 1 }, { 6, 5, 2, 2, 7 }, { 2, 6, 4, 6, 6 }, { 7, 5, 5, 2, 6 }, { 3, 1, 5, 7, 7 } };
            Assert.AreEqual(68, ds.Calculate(array));
        }
    }
}
