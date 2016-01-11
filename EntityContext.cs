using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repository
{
    public class EntityContext<T> : DbContext where T : class
    {
        public DbSet<T> Entity { get; set; }

        public EntityContext(string connectionString) : base(connectionString)
        {
            
        }
    }
}
