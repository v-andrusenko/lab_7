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
        int[,] array;
        public MyMatrix(int columns, int rows)
        {
            this.rows = rows;
            this.columns = columns;
            array = new int[columns, rows];
        }
        
    }
}
