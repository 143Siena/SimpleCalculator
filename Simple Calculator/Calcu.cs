﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public delegate int GetAnswer(int x, int y);
    class Calcu
    {
          
        public static int getSum(int num1, int num2)
        {
            return num1 + num2;

        }
        public static int getDifference(int num1, int num2)
        {
            return num1 - num2;

        }
        public static int getProduct(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int getQuotient(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}

