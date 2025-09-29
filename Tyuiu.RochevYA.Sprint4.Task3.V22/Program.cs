using Tyuiu.RochevYA.Sprint4.Task3.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] array = new int[,] { { 4, 4, 7, 8, 9 }, { 9, 5, 9, 7, 8 }, { 7, 4, 9, 4, 6 }, { 4, 4, 7, 4, 4 }, { 4, 5, 8, 6, 7 } };
        Console.WriteLine(ds.Calculate(array));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}
