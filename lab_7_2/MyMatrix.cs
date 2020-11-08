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
        
    }
}
