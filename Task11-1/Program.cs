using System;
using Task_11.Models;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grup nomresini daxil edin!");
            string q = Console.ReadLine();
            Console.WriteLine("Ad ve Soyadi daxil edin!");
            string w = Console.ReadLine();
            Console.WriteLine("Yasi daxil edin!");
            string e =Console.ReadLine();

            Student student = new Student(q, w, e);

            student.ShowInfo();
        }
    }
}
