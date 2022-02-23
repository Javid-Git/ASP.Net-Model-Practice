using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_2.Extebsion
{
    static class ExtentionMethods
    {
        public static bool IsEven(this int even)
        {
            if(even % 2 == 0)
            {
                Console.WriteLine("Cutdur");
                return true;
            }
            else
            {
                Console.WriteLine("Tekdir");
                return false;
            }
        }

        public static bool IsOdd(this int odd)
        {
            if (odd % 2 != 0)
            {
                Console.WriteLine("Tekdir");
                return true;
            }
            else
            {
                Console.WriteLine("Cutdur");
                return false;
            }
        }

        public static int[] GetValueIndexes(this int[] numarr, int num)
        {

            int count = 0;
            int index = 0;
            int[] indexes = new int[0]; 
            if (numarr.Contains(num))
            {
                foreach (int item in numarr)
                {
                    if(item == num)
                    {
                        Array.Resize(ref indexes, indexes.Length + 1);
                        indexes[index] = count;
                        index++;
                    }
                    count++;
                }
            }return indexes;
        }

        public static bool IsContainsDigit(this string digit)
        {
            foreach (char item in digit)
            {
                if (Char.IsDigit(item))
                {
                    Console.WriteLine("Daxilinde reqem var");
                    return true;
                }
            }
            Console.WriteLine("Daxilinde reqem yoxdur");
            return false;
        }

        public static int[] GetValueIndexes(this string strarr, char str)
        {
            int[] array = new int[0];
            int count1 = 0;
            int index = 0;
            if (strarr.Contains(str))
            {
                foreach (char item in strarr)
                {
                    if(item == str)
                    {
                        Array.Resize(ref array, array.Length + 1);
                        array[index] = count1;
                        index++;
                    }
                    count1++;
                }
            }return array;
        }
    }
}
