using Tyuiu.RochevYA.Sprint4.Task4.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string text = Console.ReadLine();
        int[,] array = new int[,] { { 6, 7, 3, 5, 1 }, { 6, 5, 2, 2, 7 }, { 2, 6, 4, 6, 6 }, { 7, 5, 5, 2, 6 }, { 3, 1, 5, 7, 7 } };
        Console.WriteLine(ds.Calculate(array));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}