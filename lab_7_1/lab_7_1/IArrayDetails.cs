using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7_1
{
    public interface IArrayDetails
    {
        int[] array { get; set; }
        int max { get; set; }
        int imax { get; set; }
        int min { get; set; }
        int imin { get; set; }
        int sum { get; set; }
        double averageValue { get; set; }
        int[] odd { get; set; }
        void Initialization();
    }
}
