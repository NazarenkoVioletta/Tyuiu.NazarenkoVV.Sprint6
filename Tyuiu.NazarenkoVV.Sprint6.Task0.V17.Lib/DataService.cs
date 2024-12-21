﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.NazarenkoVV.Sprint6.Task0.V17.Lib
{
    public class DataService : ISprint6Task0V17
    {
        public double Calculate(int x)
        {
            double res = Math.Round(Math.Exp(x) / x, 3);
            return res;

        }
    }
}
