namespace WareHouse
{
    class Water : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public Water(string name, string manufacturer, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public Water()
        {
        }

        public override string ToString()
        {
            return $"{Name} {Manufacturer} {Price}";
        }
    }
}
