﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ElsufevMP.Sprint3.Task3.V4.Lib
{
    public class DataService : ISprint3Task3V4
    {
        public string DeleteCharInString(string value, char item)
        {
            int count = 0;
            foreach (char chr in value)
            {
                if (chr == item)
                {
                    value = value.Replace(item, ' ');
                } 
            }
            return value;

        }
    }
}
