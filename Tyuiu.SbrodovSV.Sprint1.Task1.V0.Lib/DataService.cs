using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SbrodovSV.Sprint1.Task1.V24.Lib
{
    public class DataService : ISprint1Task1V24
    {
        public double Calculate(double x, double y)
        {
            return (1 - x) / (2 + y);
        }
    }
}
