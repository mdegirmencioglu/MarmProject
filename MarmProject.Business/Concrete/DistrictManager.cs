using MarmProject.Business.Abstract;
using MarmProject.DataAccess.Abstract;
using MarmProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public void Add(District entity)
        {
            _districtDal.Add(entity);
        }

        public void Delete(District entity)
        {
            _districtDal.Delete(entity);
        }

        public List<District> GetAll()
        {
            return _districtDal.GetAll();
        }

        public District GetById(int id)
        {
            return _districtDal.GetByID(id);
        }

        public void Update(District entity)
        {
            _districtDal.Update(entity);
        }
    }
}
