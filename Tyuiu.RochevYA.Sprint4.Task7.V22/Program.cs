using Tyuiu.RochevYA.Sprint4.Task7.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int n = 5;
        int m = 3;
        string text= "695324951753684";
        Console.WriteLine(ds.Calculate(n,m,text));
        Console.WriteLine("Сделал Рочев Ярослав Антонович | ИБКСб-25-1");
    }
}