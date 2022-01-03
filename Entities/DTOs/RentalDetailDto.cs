using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class RentalDetailDto:IDto
    {
        public int id { get; set; }
        public string CarBrandName { get; set; }
        public string CarDesciription { get; set; }
        public string CustomerFirstNameLastName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
