using System;
using System.Data;
using System.Xml;

namespace WorkshopIEnumerables.Logic
{
    public class Matrix
    {
        #region Atributtes
        private int _n;
        private int[,] matriz;
        #endregion
        #region Properties
        public Matrix(int[,] data)
        {
            matriz = data;
        }
        #endregion
        #region Constructors
        public Matrix(int rows, int columns)
        {
            matriz = new int[rows, columns];
        }
        public Matrix()
        {
            matriz = new int[0,0];
        }
        #endregion

        #region Metoth
        public string Imprint(int[,] matriz)
        {
            int rows = matriz.GetLength(0);
            int columns = matriz.GetLength(1);
            String output = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    output += matriz[i, j] + "\t";
                    Console.Write("Pase por aca");
                }
                output += "\n";
            }
            return output;
        }
        public int[,] CreateArraysA(int rows, int columns)
        {
            int[,] matrixA = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixA[i, j] = (i + 1) * j;
                }
            }
            return matrixA;
        }

        public int[,] CreateArraysB(int rows, int columns)
        {
            int[,] matriz = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matriz[i, j] = (j + 1) * i;
                }
            }
            return matriz;
        }
       
        public int[,] MatrixMultiplier(int[,] matrixA, int[,] matrixB, int m, int n, int p)
        {
            int[,] matriz = new int[m,p];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        matriz[i,j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            return matriz;
        }
        #endregion
    }
}
