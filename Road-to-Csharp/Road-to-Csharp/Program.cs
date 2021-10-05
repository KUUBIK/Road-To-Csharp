using System;
using Codewars;
using System.Linq;

namespace Road_to_Csharp
{
    class Program
    {
        //Extension String methods
        static void Main(string[] args)
        {
            
            

        }
    }


    static class StringExtension
    {
        public static void NewExtReversedStringMethods(this string msg, ref string t, ref string z)
        {
            string a = z;
            z = t;
            t = a;
        }


    }
}
