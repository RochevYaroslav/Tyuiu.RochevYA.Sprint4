﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.RochevYA.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
    {
        public int Calculate(int[] array)
        {
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0)
                {
                    k += array[i];
                }
            }
            return k;
        }
    }
}
