using MarmProject.Business.Abstract;
using MarmProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MarmProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {

        IDistrictService _districtService;

        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;       
         
        }

        [HttpGet("getall")]

        public List<District> Get()
        {
            return _districtService.GetAll();
        }

        [HttpPost("add")]

        public District Add(District district)
        {
            _districtService.Add(district);
            return district;
        }

        [HttpGet("getbyid")]

        public District GetById(int id)
        {
            return _districtService.GetById(id);
        }

        [HttpPost("delete")]

        public District Delete(District district)
        {
            _districtService.Delete(district);
            return district;
        }

    }
}
