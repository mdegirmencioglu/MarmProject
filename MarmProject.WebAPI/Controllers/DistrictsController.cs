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

        [HttpGet]

        public List<District> Get()
        {
            return _districtService.GetAll();
        }

        
    }
}
