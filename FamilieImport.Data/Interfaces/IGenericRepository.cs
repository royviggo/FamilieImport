using System;
using System.Collections.Generic;

namespace ImportLegacy.Data.Interfaces
{
    public interface IGenericRepository<TEntity> : IDisposable where TEntity : class, new()
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
    }
}