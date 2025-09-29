using System.Linq;
using Tyuiu.RochevYA.Sprint4.Task5.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int[,] array = new int[5, 5];
        for (int i = 0; i < 5; i++)
        {
            int[] row = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            for (int j = 0; j < 5; j++)
                array[i, j] = row[j];
        }
        Console.WriteLine(ds.Calculate(array));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}