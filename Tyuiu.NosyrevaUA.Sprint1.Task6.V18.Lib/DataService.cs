﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.NosyrevaUA.Sprint1.Task6.V18.Lib
{
    public class DataService : ISprint1Task6V18
    {
        public bool CheckNumber(string value)
        {
            bool isNumber = value.All(char.IsDigit);
            if (isNumber == true)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
