using Tyuiu.RochevYA.Sprint4.Task6.V4.Lib;
namespace Tyuiu.RochevYA.Sprint4.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string[] array = ["Москва", "Санкт Петербург", "Новосибирск", "Екатеринбург", "Нижний Новгород", "Казахстан", "Самара"];
            string[] answer = ["Москва", "Самара"];
            CollectionAssert.AreEqual(answer, ds.Calculate(array));
        }
    }
}
