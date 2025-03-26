﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistractionsTracker.Helpers
{
    internal class Utils
    {
        public static int ConvertCountCellToNumber(string value)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                char character = value[i];
                bool isDigit = character >= '0' && character <= '9';
                bool isNegativeSign = i == 0 && character == '-';

                if (isDigit || isNegativeSign)
                {
                    sb.Append(character);
                }
            }
            return Convert.ToInt32(sb.ToString());
        }
    }
}
