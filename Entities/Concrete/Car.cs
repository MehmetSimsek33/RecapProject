using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
     public  class Car: IEntity
    {
        public int id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public String Description { get; set; }
    }
}
