using System;

namespace CodeFirst.Entity
{
    public class Biography : BaseEntity
    {
        public string BiographyData { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Nationality { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}