using System.Collections.Generic;

namespace CodeFirst.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
