using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_manipulaton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Console.WriteLine("The real Original matrix is:");
            PrintMatrix(matrix);

            int[,] transposedMatrix = TransposeMatrix(matrix);
            Console.WriteLine("\n The Transposed matrix is :");
            PrintMatrix(transposedMatrix);

            int[,] rotatedMatrix = RotateMatrix(matrix);
            Console.WriteLine("\n The Rotated matrix is :");
            PrintMatrix(rotatedMatrix);
        }

        static int[,] TransposeMatrix(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);
            int[,] transposedMatrix = new int[numCols, numRows];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }

        static int[,] RotateMatrix(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);
            int[,] rotatedMatrix = new int[numCols, numRows];

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    rotatedMatrix[numCols - 1 - j, i] = matrix[i, j];
                }
            }

            return rotatedMatrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}

