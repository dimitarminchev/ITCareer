using System.Collections.Generic;

namespace CodeFirst.Entity
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
