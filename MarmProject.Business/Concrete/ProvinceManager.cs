using MarmProject.Business.Abstract;
using MarmProject.DataAccess.Abstract;
using MarmProject.Entities.Concrete;
using MarmProject.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.Business.Concrete
{
    public class ProvinceManager : IProvinceService
    {

        IProvinceDal _provinceDal;
        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }

        public void Add(Province entity)
        {
            _provinceDal.Add(entity);
        }

        public void Delete(Province entity)
        {
            _provinceDal.Delete(entity);
        }

        public List<Province> GetAll()
        {
            return _provinceDal.GetAll();
        }

        public Province GetById(int id)
        {
            return _provinceDal.GetByID(id);
        }

        public List<ProvinceDistrictDto> GetDistrictDtos(int id)
        {
            return _provinceDal.GetDistricts(id);
        }

        public void Update(Province entity)
        {
            _provinceDal.Update(entity);
        }
    }
}
