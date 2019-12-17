using ImportLegacy.Data.Interfaces;
using ImportLegacy.Data.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Dapper.Contrib.Extensions;

namespace ImportLegacy.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        protected readonly IDbConnection _dbFactory;
        protected readonly IDbTransaction _transaction;

        public GenericRepository(IDbConnection dbFactory)
        {
            _dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));
        }

        //protected readonly IDbFactory _dbFactory;
        //protected readonly IDbTransaction _transaction;

        //public GenericRepository(IDbFactory dbFactory, IDbTransaction transaction)
        //{
        //    _dbFactory = dbFactory ?? throw new ArgumentNullException(nameof(dbFactory));
        //    _transaction = transaction ?? throw new ArgumentNullException(nameof(transaction));
        //}

        public void Dispose()
        {
            _transaction.Dispose();
            _dbFactory.Dispose();
        }

        public IDbConnection Db => _dbFactory;
        //public IDbTransaction DbTransaction => _transaction;

        public virtual TEntity Get(int id)
        {
            return Db.Get<TEntity>(id);
            //return Db.Context().Get<TEntity>(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetList(string.Empty);
        }

        public virtual IEnumerable<TEntity> GetList(string where)
        {
            return GetList(where, null, string.Empty);
        }

        public virtual IEnumerable<TEntity> GetList(string where, object param, string orderBy)
        {
            var query = GetBaseQuery().Where(where).OrderBy(orderBy);

            return GetListSql(query, param);
        }

        public virtual IEnumerable<TEntity> GetListSql(string query, object param)
        {
            return Db.Query<TEntity>(query, param);
        }

        public virtual string GetBaseQuery()
        {
            return typeof(TEntity).Select();
        }
    }
}