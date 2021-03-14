namespace WareHouse
{
    interface IProduct
    {
        int Id { get; set; }

        string Name { get; set; }

        string Manufacturer { get; set; }

        double Price { get; set; }
    }
}
