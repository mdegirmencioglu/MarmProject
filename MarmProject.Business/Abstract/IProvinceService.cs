using MarmProject.Entities.Concrete;
using MarmProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.Business.Abstract
{
    public interface IProvinceService:IGenericService<Province>
    {

        List<ProvinceDistrictDto> GetDistrictDtos(int id);
    }
}
