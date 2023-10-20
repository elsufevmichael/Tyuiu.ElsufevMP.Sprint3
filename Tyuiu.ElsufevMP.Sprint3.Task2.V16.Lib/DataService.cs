﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElsufevMP.Sprint3.Task2.V16.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double series = 1;
            do
            {
                series = series * Math.Pow((1 / Math.Pow(startValue, value)), -1);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(series, 3);
        }
    }
}
