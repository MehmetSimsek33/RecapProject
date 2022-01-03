﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
  public  class Customer:IEntity
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public int? CustomerFindexPoint { get; set; }
    }
}
