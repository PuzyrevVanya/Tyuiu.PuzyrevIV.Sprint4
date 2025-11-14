using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PuzyrevIV.Sprint4.Task5.V26.Lib
{
    public class DataService : ISprint4Task4V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows == 0 || cols == 0)
                throw new ArgumentException("Массив не может быть пустым.", nameof(matrix));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                        matrix[i, j] = 1;
                }
            }

            return matrix;
        }
    }
}

