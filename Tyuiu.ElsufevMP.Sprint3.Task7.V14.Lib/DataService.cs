﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElsufevMP.Sprint3.Task7.V14.Lib
{
    public class DataService : ISprint3Task7V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 1 == 0)
                { y = 0; }
                else
                {
                    y = Math.Round((2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1)), 2);
                }

                    valueArray[count] = y;
                    count++;
            }
            return valueArray;
        }
    }
}
