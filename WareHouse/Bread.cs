namespace WareHouse
{
    class Bread : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public Bread(string name, string manufacturer, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public Bread()
        {
        }

        public override string ToString()
        {
            return $"{Name} {Manufacturer} {Price}";
        }
    }
}
