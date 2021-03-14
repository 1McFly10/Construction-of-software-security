using System.Collections.Generic;

namespace WareHouse
{
    internal interface IWareHouseService
    {
        void AddProduct(IProduct product);

        void RemoveProduct(string name);

        List<IProduct> GetProducts();
    }
}