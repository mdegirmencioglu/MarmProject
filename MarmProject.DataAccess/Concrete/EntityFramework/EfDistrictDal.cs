using MarmProject.Core.DataAccess.EntityFramework;
using MarmProject.DataAccess.Abstract;
using MarmProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal:EfEntityRepositoryBase<District,MarmProjectContext>,IDistrictDal
    {
    }
}
