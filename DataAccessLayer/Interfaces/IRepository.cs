using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        bool Create(TEntity entity);
        IEnumerable<TEntity> Read();
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
