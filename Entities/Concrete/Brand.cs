using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Brand:Entity
    {
        public int id { get; set; }
        public int BrandName { get; set; }
    }
}
