using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NosyrevaUA.Sprint1.Task7.V13.Lib
{
    public class DataService : ISprint1Task7V13
    {
        public double Calculate(double x, double y)
        {
            return ((y*y - Math.Cos(x)*Math.Cos(x) + 10) / (x*x - Math.Sin(y)*Math.Sin(y) + 12));
        }
    }
}
