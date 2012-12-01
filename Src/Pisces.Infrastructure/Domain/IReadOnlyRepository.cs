using System;
using System.Collections.Generic;

namespace Pisces.Infrastructure.Domain
{
    public interface IReadOnlyRepository<T, TId>
    {
        T Get(TId id);
        IEnumerable<T> GetAll();
    }
}
