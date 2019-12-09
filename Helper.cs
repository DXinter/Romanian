using System;
using System.Collections.Generic;
using System.Text;

namespace Romanian
{
    public static class  Helper
    {
        public static string ToRomanian(this int input)
        {
            int[] mas1 = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] mas2 = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int i = 0;         
            string s = "";
            while (input > 0) 
            {
                if (mas1[i] <= input)
                {                     
                    input -= mas1[i];   
                    s += mas2[i];
                }                      
                else 
                    i++;
            }
            return s;
        }
    }
}
