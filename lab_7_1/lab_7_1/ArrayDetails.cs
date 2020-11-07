using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_1
{
    class ArrayDetails : IArrayDetails
    {
        int length { get; set; }
        public ArrayDetails(int length)
        {
            this.length = length;
        }
        public int[] array { get; set; }
        public int max { get; set; }
        public int imax { get; set; }
        public int min { get; set; }
        public int imin { get; set; }
        public int sum { get; set; }
        public double averageValue { get; set; }
        public int[] odd { get; set; }
        public void Initialization()
        {
            this.array = new int[length];
            int oddlength = 0;
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                this.array[i] = random.Next(-1000, 1001);
                if (this.array[i] % 2 != 0) oddlength++;
            }
            this.max = this.array[0];
            this.imax = 0;
            this.min = this.array[0];
            this.imin = 0;
            this.sum = 0;


            for (int i = 0; i < this.length; i++)
            {
                this.sum += this.array[i];
                if (this.max < this.array[i])
                {
                    this.max = this.array[i];
                    this.imax = i;
                }
                if (min > array[i])
                {
                    this.min = this.array[i];
                    this.imin = i;
                }
            }
            this.averageValue = this.sum / this.length;
            int k = 0;
            odd = new int[oddlength];
            for (int i = 0; i < length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    odd[k] = array[i];
                    k++;
                }
            }
        }
    }
}
