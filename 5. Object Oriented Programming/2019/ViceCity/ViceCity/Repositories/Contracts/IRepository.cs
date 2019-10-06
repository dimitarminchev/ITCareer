using ViceCity.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Repositories.Contracts
{
    public interface IRepository<T>
    {
        IReadOnlyCollection<T> Models { get; }

        void Add(IGun model);

        bool Remove(IGun model);

        IGun Find(string name);

    }
}
