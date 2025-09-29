using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RochevYA.Sprint4.Task6.V4.Lib
{
    public class DataService : ISprint4Task6V4
    {
        public string[] Calculate(string[] array)
        {
            string[] res= new string[2];
            int k =0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i].Length < 7)
                {
                    res[k]=array[i];
                    k++;
                }
            }
            return res;
        }
    }
}
