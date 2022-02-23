using System;
using Task10_3.Models;
namespace Task10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nece dene mehsul elave etmek isteyirsiniz");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Mehsul novunu secin!");
                foreach (var item in Enum.GetValues(typeof(ProductType)))
                {
                    Console.WriteLine($"{(int)item}. {item}");
                }
                string str = Console.ReadLine();
                int num;

                while (!int.TryParse(str, out num) || num < 1 || num > 4)
                {
                    Console.WriteLine("Duzgun reqem daxil edin!");
                    str = Console.ReadLine();
                }
                ProductType product = (ProductType)num;
                Console.WriteLine("Qiymeti daxil edin");
                double price = double.Parse(Console.ReadLine());
                Product nproduct = new Product(product, price);
                if (num == 1)
                {
                    nproduct.DiscountedPrice = nproduct.Price * 0.9;
                }
                nproduct.ChangeCode(product.ToString());

                Console.WriteLine("Mehsulun adini daxil edin!");
                nproduct.Name = Console.ReadLine();
                nproduct.ShowInfo();

                if(i != (count - 1))
                {
                    Console.WriteLine("Davam etemek isteyirsiniz? y/n");
                    char valid = char.Parse(Console.ReadLine());
                    if (valid != 'y')
                    {
                        break;
                    }
                }
                
            }
            



        }
    }
}
