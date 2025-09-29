using Tyuiu.RochevYA.Sprint4.Task1.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        string text = Console.ReadLine();
        Console.WriteLine(ds.Calculate(text.Split(',').Select(int.Parse).ToArray()));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}