using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XxMeatKritikxX.App.Model;
using XxMeatKritikxX.App.Model.DAO;

namespace XxMeatKritikxX.App.Repository;

public class VideoGameRepository : EntityRepository<VideoGame>
{
    public VideoGameRepository()
        : base(new VideoGameDAO())
    { }
}
