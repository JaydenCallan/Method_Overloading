﻿using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isDollar)
        {
            if (isDollar == true && num1+num2 == 1)
            {
                return $"{num1 + num2} dollar";
            }
            else if (isDollar == true)
            {
                return $"{num1 + num2} dollars";
            }
            else
            {
                return $"{num1 + num2}";
            }
        }
        static void Main(string[] args)
        {
        }
    }
}