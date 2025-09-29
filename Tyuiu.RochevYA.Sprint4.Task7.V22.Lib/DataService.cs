using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RochevYA.Sprint4.Task7.V22.Lib
{
    public class DataService : ISprint4Task7V22
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] array = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int index = i * m + j;
                    array[i, j] = int.Parse(value[index].ToString());
                }
            }

            int res = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        res*=array[i, j];
                    }
                }
            }

            return res;
        }
    }
}
