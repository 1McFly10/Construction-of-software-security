using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WareHouse
{
    class WareHouseService : IWareHouseService
    {
        private List<IProduct> Products { get; set; }
        private ProductContext ProductContext;
        Logger logger = LogManager.GetCurrentClassLogger();

        public WareHouseService()
        {
            Products = new List<IProduct>();
            ProductContext = new ProductContext();
        }

        public void AddProduct(IProduct product)
        {
                Products.Add(product);

                if (product is Milk)
                {
                    ProductContext.Milks.Add(product as Milk);
                }

                if (product is Bread)
                {
                    ProductContext.Breads.Add(product as Bread);
                }

                if (product is Water)
                {
                    ProductContext.Waters.Add(product as Water);
                }

                if (product is Tea)
                {
                    ProductContext.Teas.Add(product as Tea);
                }

                ProductContext.SaveChanges();
        }

        public void RemoveProduct(string name)
        {
            try
            {
                Products.Remove(Products.FirstOrDefault(x => x.Name == name));
                var milkForRemove = ProductContext.Milks?.FirstOrDefault(x => x.Name == name);
                var breadForemove = ProductContext.Breads?.FirstOrDefault(x => x.Name == name);
                var waterforremove = ProductContext.Waters?.FirstOrDefault(x => x.Name == name);
                var teaRemove = ProductContext.Teas?.FirstOrDefault(x => x.Name == name);

                if (milkForRemove != null)
                {
                    ProductContext.Milks.Remove(milkForRemove);
                }

                if (breadForemove != null)
                {
                    ProductContext.Breads.Remove(breadForemove);
                }

                if (waterforremove != null)
                {
                    ProductContext.Waters.Remove(waterforremove);
                }

                if (teaRemove != null)
                {
                    ProductContext.Teas.Remove(teaRemove);
                }

                ProductContext.SaveChanges();
            }
            catch(Exception exception)
            {
                logger.Error(exception);
            }
        }

        public List<IProduct> GetProducts()
        {
            var collection = new List<IProduct>();
            collection.AddRange(ProductContext.Milks.ToList());
            collection.AddRange(ProductContext.Breads.ToList());
            collection.AddRange(ProductContext.Waters.ToList());
            collection.AddRange(ProductContext.Teas.ToList());

            return collection.ToList();
        }

    }
}
