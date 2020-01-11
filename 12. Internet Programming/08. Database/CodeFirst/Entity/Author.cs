namespace CodeFirst.Entity
{
    public class Author : BaseEntity
    {
        public string FirsName { get; set; }

        public string LastName { get; set; }

        public int BiographyId { get; set; }

        public virtual Biography Biography { get; set;  }
    }
}
