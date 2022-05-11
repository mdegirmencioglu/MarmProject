using MarmProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarmProject.Entities.Concrete
{
    public class Province:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
