using MarmProject.Core.DataAccess.EntityFramework;
using MarmProject.DataAccess.Concrete.EntityFramework;
using MarmProject.Entities.Concrete;
using MarmProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.DataAccess.Abstract
{
    public interface IProvinceDal:IEntityRepository<Province>
    {

        List<ProvinceDistrictDto> GetDistricts(int id);


    }
}
