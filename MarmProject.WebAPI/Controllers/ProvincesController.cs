using MarmProject.Business.Abstract;
using MarmProject.Business.Concrete;
using MarmProject.DataAccess.Abstract;
using MarmProject.Entities.Concrete;
using MarmProject.Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;

namespace MarmProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvincesController : ControllerBase
    {

                IProvinceService _provinceService;

        public ProvincesController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
           
        }

        [HttpGet("getall")]

        public List<Province> GetAll()
        {
                        
            return _provinceService.GetAll();
        }

        [HttpGet("getbyid")]
        
        public Province GetById(int id)
        {
            return _provinceService.GetById(id);
        }

        [HttpGet("getdistricts")]

        public List<ProvinceDistrictDto> GetDistricts(int id)
            {
                return _provinceService.GetDistrictDtos(id);

            }

        [HttpPost("add")]

        public Province Add(Province province)
        {
            _provinceService.Add(province);
            return province;
        }

        [HttpPost("delete")]

        public Province Delete(Province province)
        {
            _provinceService.Delete(province);
            return province;
        }


    }
}
