using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11.Models
{
    class Student
    {

        private string _groupNo;
        public string GroupNo 
        {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Bir daha sinayin!");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }
        private string _fullname;
        public string Fullname
        {
            get => _fullname;
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("Bir daha sinayin!");
                    value = Console.ReadLine();
                }
                _fullname = value;
            }
        }
        private string _age;
        public string Age 
        {
            get => _age;
            set
            {
                while (!CheckAge(value))
                {
                    Console.WriteLine("Bir daha sinayin!");
                    value = Console.ReadLine();
                }
                _age = value;
            }
        }

        public Student(string groupno, string fullname, string age)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Age = age;
        }
        static bool CheckGroupNo(string a)
        {
            if (a.Length == 4)
            {
                int i = 0;
                if (!Char.IsUpper(a[i]) || !Char.IsDigit(a[i + 1]) || !Char.IsDigit(a[i + 2]) || !Char.IsDigit(a[i + 3]))
                {
                    Console.WriteLine("Bir boyuk herf ve 3 dene reqem olmalidir!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Grup adi 4 eded olmalidir!");
                return false;
            }
        }
        static bool CheckFullname(string b)
        {
            if(b.Contains(' '))
            {
                if (Char.IsUpper(b[0]) && Char.IsLetter(b[0]))
                {
                    if (!Char.IsUpper(b[b.IndexOf(' ') + 1]) && !Char.IsLetter(b[b.IndexOf(' ') + 1]))
                    {
                        Console.WriteLine("Format bele olmalidir: Ad + bosluq + Soyad.");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Format bele olmalidir: Ad + bosluq + Soyad.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Format bele olmalidir: Ad + bosluq + Soyad.");
                return false;
            }
        }
        static bool CheckAge(string c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (Char.IsDigit(c[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Yas reqem ile yazilmalidir!");
                    return false;
                }
            }return true;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"********Telebe haqqinda melumat********\n{Age} yasli {Fullname}, {GroupNo} qrupda oxuyur.");
        }
    }
}
