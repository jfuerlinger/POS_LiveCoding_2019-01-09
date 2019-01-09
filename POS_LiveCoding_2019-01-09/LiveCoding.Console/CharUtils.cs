using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCoding.Console
{
    static class CharUtils
    {
        //public static bool IsDigit(char ch)
        //{
        //    return Char.IsDigit(ch);
        //}

        public static bool IsDigit(this char ch)
        {
            return Char.IsDigit(ch);
        }

        public static char ToUpper(this char ch)
        {
            //return Char.ToUpper(ch);
            return char.ToUpper(ch);
        }

    }
}
