using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Card : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpirationDate { get; set; }
        public int CardCvv { get; set; }
    }
}