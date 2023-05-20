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
        public int N { get; set; }
        public Matrix(int n)
        {
            this._n = n;
            matriz = new int[N, N];
        }
        public Matrix(int[,] n)
        {
            matriz = n;
        }
        #endregion
        #region Constructors
        public Matrix(int rows, int columns)
        {
            matriz = new int[rows, columns];
            _n = columns;
        }
        
        public Matrix()
        {
            matriz = new int[0,0];
        }
       
        #endregion

        #region Metoth
        public override string ToString()
        {
            int rows = matriz.GetLength(0);
            int columns = matriz.GetLength(1);
            String output = String.Empty;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    output += matriz[i, j] + "\t";
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

        public int[,] FillMatrix2x2(int N)
        {
            int[,] matriz = new int[N, N];
            int number = 0, dataDouble = 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = number;
                    number++;
                }
                number = dataDouble;
                dataDouble += 2;
            }
            return matriz;
        }

        public string ToStringHourglass(int[,] matriz)
        {
            int order = matriz.GetLength(1);
            var output = string.Empty;
            for (int i = 0; i < ((matriz.GetLength(0) - 1) / 2); i++)
            {
                for (int j = 0; j < order; j++)
                {
                    if (i <= j && i + j <= order - 1 && i <= order - 1 - j)
                        output += matriz[i, j] + "\t";
                    else
                        output += "\t"; 
                }
                output += "\n";
            }
            return output;
        }

        public string ToStringMatrixInverse(string[,] matriz)
        {
            string output = string.Empty;
            for (int i = ((matriz.GetLength(0) - 1) / 2); i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j].Equals("\t"))
                    {
                        
                    }
                    output += Convert.ToString(matriz[i, j] + "\t");
                }
                output += "\n";
            }
            return output;
        }
        public string[,] ToStringHourglassReves(int[,] matriz)
        {
            int order = matriz.GetLength(1);
            string[,] output = new string[order, order];
            for (int i = order - 1; i >= 0; i--)
            {
                for (int j = order- 1; j >= 0; j--)
                {
                    if ((i >= j && i - j <= order - 1 && i >= order - 1 - j))
                        output[i, j] = matriz[i, j].ToString();
                    else
                        output[i, j] = string.Empty;
                }
            }
            return output;
        }

        
        #endregion
    }
}
