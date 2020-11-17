using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace lab_7_2
{
    class MyMatrix
    {
        
        public int rows;
        public int columns;
        public int[,] array;
        public MyMatrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            array = new int[rows, columns];
        }
        public void ResizeArray(MyMatrix baseMatrix, int newRows, int newColumns)
        {
            this.array = new int[rows, columns];
            if (newRows>=baseMatrix.rows && newColumns>=baseMatrix.columns)
            {
                for (int i = 0; i < baseMatrix.rows; i++)
                {
                    for (int k = 0; k < baseMatrix.columns; k++)
                    {
                        this.array[i, k] = baseMatrix.array[i, k];
                    }
                }
            }
            else if (newRows < baseMatrix.rows && newColumns < baseMatrix.columns)
            {
                for (int i = 0; i < newRows; i++)
                {
                    for (int k = 0; k < newColumns; k++)
                    {
                        this.array[i, k] = baseMatrix.array[i, k];
                    }
                }
            }
            else if (newRows >= baseMatrix.rows && newColumns < baseMatrix.columns)
            {
                for (int i = 0; i < baseMatrix.rows; i++)
                {
                    for (int k = 0; k < newColumns; k++)
                    {
                        this.array[i, k] = baseMatrix.array[i, k];
                    }
                }
            }
            else if (newRows < baseMatrix.rows && newColumns >= baseMatrix.columns)
            {
                for (int i = 0; i < newRows; i++)
                {
                    for (int k = 0; k < baseMatrix.columns; k++)
                    {
                        this.array[i, k] = baseMatrix.array[i, k];
                    }
                }
            }
            
        }
    }
}
