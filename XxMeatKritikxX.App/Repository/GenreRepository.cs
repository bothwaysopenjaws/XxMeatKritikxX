using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XxMeatKritikxX.App.Model;
using XxMeatKritikxX.App.Model.DAO;

namespace XxMeatKritikxX.App.Repository;

public class GenreRepository : EntityRepository<Genre>
{
    public GenreRepository()
        : base(new GenreDAO())
    { }

    public Genre GetByName(string name) => ((GenreDAO)this._EntityDAO).GetByName(name);

}
