using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbSet<TEntity> _dbSet;

        public Repository()
        {
            const string connstring = @"Data Source=ALPHA-PC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            var dbContext = new DatabaseContext<TEntity>(connstring);
            _dbSet = dbContext.Set<TEntity>();
        }


        public IList<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
