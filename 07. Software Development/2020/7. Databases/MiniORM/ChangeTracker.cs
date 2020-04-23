namespace MiniORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    internal class ChangeTracker<T>
        where T : class, new()
    {
        private readonly List<T> allEntities;

        private readonly List<T> added;

        private readonly List<T> removed;

        public ChangeTracker(IEnumerable<T> entities)
        {
            this.added = new List<T>();
            this.removed = new List<T>();

            this.allEntities = CloneEntities(entities);
        }

        public IReadOnlyCollection<T> AllEntities => this.allEntities.AsReadOnly();

        public IReadOnlyCollection<T> Added => this.added.AsReadOnly();

        public IReadOnlyCollection<T> Removed => this.removed.AsReadOnly();

        public void Add(T item)
        {
            this.added.Add(item);
        }

        public void Remove(T item)
        {
            this.removed.Add(item);
        }

        public IEnumerable<T> GetModifiedEntities(DbSet<T> dbSet)
        {
            List<T> modifiedEntities = new List<T>();

            PropertyInfo[] primaryKeys = typeof(T)
                .GetProperties()
                .Where(pk => pk.HasAttribute<KeyAttribute>())
                .ToArray();

            foreach (T proxyEntity in this.AllEntities)
            {
                object[] primaryKeyValues = GetPrimaryKeyValues(primaryKeys, proxyEntity).ToArray();

                T entity = dbSet
                    .Entities
                    .Single(e => GetPrimaryKeyValues(primaryKeys, e).SequenceEqual(primaryKeyValues));

                bool isModified = IsModified(proxyEntity, entity);
                if (isModified)
                {
                    modifiedEntities.Add(entity);
                }
            }

            return modifiedEntities;
        }

        private static bool IsModified(T proxyEntity, T entity)
        {
            IEnumerable<PropertyInfo> monitoredProperties = typeof(T)
                .GetProperties()
                .Where(mp => DbContext.AllowedSqlTypes.Contains(mp.PropertyType));

            PropertyInfo[] modifiedProperties = monitoredProperties
                .Where(mp => !Equals(mp.GetValue(entity), mp.GetValue(proxyEntity)))
                .ToArray();

            bool isModified = modifiedProperties.Any();

            return isModified;
        }

        private static IEnumerable<object> GetPrimaryKeyValues(IEnumerable<PropertyInfo> primaryKeys, T proxyEntity)
        {
            return primaryKeys.Select(pk => pk.GetValue(proxyEntity));
        }

        private static List<T> CloneEntities(IEnumerable<T> entities)
        {
            List<T> clonedEntities = new List<T>();

            PropertyInfo[] propertiesToClone = typeof(T)
                .GetProperties()
                .Where(pi => DbContext.AllowedSqlTypes.Contains(pi.PropertyType))
                .ToArray();

            foreach (T entity in entities)
            {
                T clonedEntity = Activator.CreateInstance<T>();

                foreach (PropertyInfo property in propertiesToClone)
                {
                    object value = property.GetValue(entity);
                    property.SetValue(clonedEntity, value);
                }

                clonedEntities.Add(clonedEntity);
            }

            return clonedEntities;
        }
    }
}