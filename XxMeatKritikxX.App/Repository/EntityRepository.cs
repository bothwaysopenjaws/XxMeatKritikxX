using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XxMeatKritikxX.App.Model.DAO;

namespace XxMeatKritikxX.App.Repository
{
    public abstract class EntityRepository<T> : IModelRepository<T>
    {
        public readonly IEntityDAO<T> _EntityDAO;

        protected EntityRepository(IEntityDAO<T> entityDAO) => _EntityDAO = entityDAO;

        public void Create(T entity) => _EntityDAO.Create(entity);

        public void Delete(T entity) => _EntityDAO.Delete(entity);

        public List<T> Read() => _EntityDAO.Read();

        public void Update(T entity) => _EntityDAO.Update(entity);
    }
}
