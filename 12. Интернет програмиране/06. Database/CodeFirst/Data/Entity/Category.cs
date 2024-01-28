namespace Data.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
