using Tyuiu.RochevYA.Sprint4.Task6.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string[] array = Console.ReadLine().Split(',');
        Console.WriteLine(string.Join(", ",ds.Calculate(array)));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}