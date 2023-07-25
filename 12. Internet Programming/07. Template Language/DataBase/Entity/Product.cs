namespace DataBase.Entity
{
    public enum Types
    {
        Food, Domestic, Health, Cosmetic, Other
    }

    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Types Type { get; set; }
    }
}
