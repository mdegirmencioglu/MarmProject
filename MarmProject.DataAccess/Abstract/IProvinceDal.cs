using MarmProject.Core.DataAccess.EntityFramework;
using MarmProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.DataAccess.Abstract
{
    public interface IProvinceDal:IEntityRepository<Province>
    {
    }
}
