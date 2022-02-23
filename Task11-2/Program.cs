using System;
using Task10_2.Extebsion;

namespace Task10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = 76;
            q.IsEven();
            q.IsOdd();
            string str1 = "Salam";
            str1.IsContainsDigit();

            string string2 = "Salam Sagol Dene Sekkiz Qogal";
            char str2 = 'e';
            string2.GetValueIndexes(str2);

            int[] integer = { 1, 4, 21, 132, 34, 42, 2432, 23, 423, 3, 4, 23, 41234, 4, 56, 2, 6736487, 859, 8, 746, 3, 1324 };
            int pop = 4;
            integer.GetValueIndexes(pop);
        }
    }
}
