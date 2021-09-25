using System;

namespace Road_to_Csharp
{
    class Program
    {
        //Extension String methods
        static void Main(string[] args)
        {
            string h = "Hello ";
            string w = "World ";
            Console.WriteLine(h + w);
            string z = default;
            z.NewExtReversedStringMethods(ref h, ref w);
            Console.WriteLine(h + w);
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
