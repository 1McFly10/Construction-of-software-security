using System;
using System.Globalization;
using System.Threading;

namespace WareHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-Ua");

            var service = new WareHouseService();

            Console.WriteLine(Resource.AddProduct);
            service.AddProduct(new Water("Bonaqua", "Obolon", 20));
            Console.WriteLine(Resource.AddProduct);
            service.AddProduct(new Bread("Bread", "KiyvHlib", 15));
            Console.WriteLine(Resource.AddProduct);
            service.AddProduct(new Milk("Milk", "Prostokvashino", 30));
            Console.WriteLine(Resource.AddProduct);
            service.AddProduct(new Bread("Bread", "KiyvHlib", 15));
            Console.WriteLine(Resource.AddProduct);
            service.AddProduct(new Water("Bonaqua", "Obolon", 20));
            Console.WriteLine(Resource.AddProduct);
            service.AddProduct(new Tea("Lipton", "Nestea", 20));

            Console.WriteLine(Resource.RemoveProduct);
            service.RemoveProduct("Milk");

            Console.WriteLine(Resource.GetProducts);

            foreach (var item in service.GetProducts())
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
