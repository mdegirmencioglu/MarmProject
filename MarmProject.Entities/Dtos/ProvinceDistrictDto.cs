using MarmProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.Entities.Dtos
{
    public class ProvinceDistrictDto:IDto
    {
        public string Province { get; set; }
        public string District { get; set; }
    }
}
