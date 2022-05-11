using MarmProject.Business.Abstract;
using MarmProject.Business.Concrete;
using MarmProject.DataAccess.Abstract;
using MarmProject.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
       
        public List<Province> Get()
        {
              return _provinceService.GetAll();
        }
        

    }
}
