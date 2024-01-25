using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VengoVE.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Log10(x * y)) / (Math.Sqrt(2 * (Math.Pow(y, 2))));
            return res;
        }
    }
}
