using System.Data.Entity;

namespace WareHouse
{
    class ProductContext: DbContext
    {
        public ProductContext()
           : base("DbConnection")
        { }

        public DbSet<Water> Waters { get; set; }
        public DbSet<Bread> Breads { get; set; }
        public DbSet<Milk> Milks { get; set; }
        public DbSet<Tea> Teas { get; set; }
    }
}
