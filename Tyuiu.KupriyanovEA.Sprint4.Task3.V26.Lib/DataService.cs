using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KupriyanovEA.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int m = array[1,0];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (array[1, j] > m)
                    {
                        m = array[1, j];
                    }
                }
            }
            return m;
        }
    }
}
