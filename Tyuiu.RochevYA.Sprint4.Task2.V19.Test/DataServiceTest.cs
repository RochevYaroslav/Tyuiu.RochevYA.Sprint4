using Tyuiu.RochevYA.Sprint4.Task2.V19.Lib;
namespace Tyuiu.RochevYA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string text = "8, 1, 5, 4, 2, 1, 2, 7, 6, 1";
            Assert.AreEqual(22, ds.Calculate(text.Split(',').Select(int.Parse).ToArray()));
        }
    }
}
