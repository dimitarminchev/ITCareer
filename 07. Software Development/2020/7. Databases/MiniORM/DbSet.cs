namespace MiniORM
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class DbSet<TEntity> : ICollection<TEntity>
        where TEntity : class, new()
    {
        internal DbSet(IEnumerable<TEntity> entities)
        {
            this.Entities = entities.ToList();
            this.ChangeTracker = new ChangeTracker<TEntity>(entities);
        }

        internal ChangeTracker<TEntity> ChangeTracker { get; set; }

        internal IList<TEntity> Entities { get; set; }

        public int Count => this.Entities.Count;

        public bool IsReadOnly => this.Entities.IsReadOnly;

        public void Add(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null!");
            }

            this.Entities.Add(item);
            this.ChangeTracker.Add(item);
        }

        public void Clear()
        {
            while (this.Entities.Any())
            {
                TEntity entity = this.Entities.First();
                this.Remove(entity);
            }
        }

        public bool Contains(TEntity item) => this.Entities.Contains(item);

        public void CopyTo(TEntity[] array, int arrayIndex)
        {
            this.Entities.CopyTo(array, arrayIndex);
        }

        public bool Remove(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null!");
            }

            bool removedSuccessufully = this.Entities.Remove(item);

            if (removedSuccessufully)
            {
                this.ChangeTracker.Remove(item);
            }

            return removedSuccessufully;
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (TEntity entity in entities.ToArray())
            {
                this.Remove(entity);
            }
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return this.Entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}