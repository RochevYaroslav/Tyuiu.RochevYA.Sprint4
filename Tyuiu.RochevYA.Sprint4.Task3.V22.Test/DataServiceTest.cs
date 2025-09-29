using Tyuiu.RochevYA.Sprint4.Task3.V22.Lib;
namespace Tyuiu.RochevYA.Sprint4.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] { { 4, 4, 7, 8, 9 }, { 9, 5, 9, 7, 8 }, { 7, 4, 9, 4, 6 }, { 4, 4, 7, 4, 4 }, { 4, 5, 8, 6, 7 } };
            Assert.AreEqual(9, ds.Calculate(array));
        }
    }
}
