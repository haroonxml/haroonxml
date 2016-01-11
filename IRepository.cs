using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Repository
{
    public interface IRepository<TEntity>
    {
        IList<TEntity> GetAll();

    }
}
