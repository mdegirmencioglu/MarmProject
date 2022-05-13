using MarmProject.Core.DataAccess.EntityFramework;
using MarmProject.DataAccess.Abstract;
using MarmProject.Entities.Concrete;
using MarmProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.DataAccess.Concrete.EntityFramework
{
    public class EfProvinceDal:EfEntityRepositoryBase<Province,MarmProjectContext>,IProvinceDal
    {
        public List<ProvinceDistrictDto> GetDistricts(int id)
        {
            using (var context = new MarmProjectContext())
            {
                var result = from province in context.Provinces
                             join district in context.Districts
                             on province.Id equals district.ProvinceId
                             where province.Id == id
                             select new ProvinceDistrictDto { District = district.Name, Province = province.Name };

                return result.ToList();





            }

        }

    }
}
