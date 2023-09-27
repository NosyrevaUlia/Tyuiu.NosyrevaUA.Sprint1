using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NosyrevaUA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            if (k%7 == 0)
            {
                int n = 7;
                return n;
            }
            else
            {
                return k % 7;
            }        

            
            
        }
    }
}
