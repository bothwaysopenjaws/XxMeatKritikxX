using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XxMeatKritikxX.App.Model;
using XxMeatKritikxX.App.Model.DAO;

namespace XxMeatKritikxX.App.Repository;

public class StudioRepository : EntityRepository<Studio>
{
    public StudioRepository()
        : base(new StudioDAO())
    { }

    public Studio GetByName(string name) => ((StudioDAO)this._EntityDAO).GetByName(name);
}
