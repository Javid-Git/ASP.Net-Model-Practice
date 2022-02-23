using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_3.Models
{
    class Product
    {
        private static int _no = 1000;
        private string _code;
        public string Name;
        public double Price;
        public double DiscountedPrice;
        public ProductType ProductType;
        public static int TotalCount = 0;

        public Product(ProductType a, double price)
        {
            ProductType = a;
            Price = price;
            _no++;
            TotalCount++;
        }
        public void ChangeCode(string eenum)
        {
            _code = $"{eenum[0]}{_no}";
        }

        public void ShowInfo()
        {
            if(ProductType == ProductType.Bakery)
            {
                Console.WriteLine($"Mehsulun novu: {ProductType}\nMehsulun adi: {Name}\nMehsulun Kodu: {_code}\n*****************\nMehsulun qiymeti: {Price}\nEndirimli qiymet: {DiscountedPrice}\n*************" +
                $"****\nUmumi mehsul sayi: {TotalCount}");
            }
            else
            {
                Console.WriteLine($"Mehsulun novu: {ProductType}\nMehsulun adi: {Name}\nMehsulun Kodu: {_code}\n*****************\nMehsulun qiymeti: {Price}\n*************" +
                $"****\nUmumi mehsul sayi: {TotalCount}");
            }
            
        }

    }
    enum ProductType
    {
        Bakery = 1,
        Drink,
        Meat, 
        Fish
    }

}
