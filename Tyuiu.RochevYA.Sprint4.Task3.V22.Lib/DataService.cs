using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RochevYA.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[0,i]>max)
                {
                    max=array[0,i];
                }
            }
            return max;
        }
    }
}
