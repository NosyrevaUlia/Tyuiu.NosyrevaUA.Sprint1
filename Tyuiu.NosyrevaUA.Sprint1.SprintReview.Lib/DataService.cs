using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NosyrevaUA.Sprint1.SprintReview.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            return (x - (Math.Pow(10, Math.Sin(x))) + ((20 * x * x) / (3 * x * x * x)) + (Math.Cos(x * x - y)));
        }
    }
}
