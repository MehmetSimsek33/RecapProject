using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
  public  class UserOperationDto:IDto
    {
        public int id { get; set; }
        public string OperationName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserFullName { get; set; }
        public string email { get; set; }

    }
}
