using Tyuiu.RochevYA.Sprint4.Task0.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[] array = new int[] { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
        Console.WriteLine(ds.GetMultEvenArrEl(array));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}