using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> Defines a matriz</summary>
    public class Matrix
    {
        /// <summary> Divides all elements of a matrix </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return null;

            int [,] NewM = matrix;
            try
            {
                for (int numero = 0; numero < matrix.GetLength(0) ; numero ++ )
                {
                    for (int val = 0; val < matrix.GetLength(1); val++)
                    {
                        NewM[numero, val] = matrix[numero, val] / num; 
                    }
                }
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            return NewM;
        }
    }
}
