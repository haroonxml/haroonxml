using System.Data.Entity;

namespace DomainModel.Repository
{
    public class DatabaseContext<TEntity> : DbContext where TEntity : class
    {
        public DatabaseContext(string connectingString): base(connectingString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TEntity>();
        }
    }
}