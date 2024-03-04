using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XxMeatKritikxX.App.Model;
using XxMeatKritikxX.App.Model.DAO;

namespace XxMeatKritikxX.App.Repository;

public class UserRepository : IModelRepository<User>
{
    private readonly UserDAO _UserDAO;

    public UserRepository() => _UserDAO = new();

    public void Create(User entity) => _UserDAO.Create(entity);

    public void Delete(User entity) => _UserDAO.Delete(entity);

    public List<User> Read() => _UserDAO.Read();

    public void Update(User entity) => _UserDAO.Update(entity);
}
