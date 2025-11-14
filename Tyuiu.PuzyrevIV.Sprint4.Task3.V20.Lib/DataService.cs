using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PuzyrevIV.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            if (array == null || array.GetLength(0) == 0 || array.GetLength(1) == 0)
            {
                throw new ArgumentException("Входной массив не может быть пустым или null.");
            }

            int rows = array.GetLength(0);

            int minElement = array[0, 0];
            for (int i = 1; i < rows; i++)
            {
                int currentElement = array[i, 0];
                if (currentElement < minElement)
                {
                    minElement = currentElement;
                }
            }

            return minElement;
        }
    }
}
