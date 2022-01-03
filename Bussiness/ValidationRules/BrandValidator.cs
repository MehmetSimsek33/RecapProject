using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.ValidationRules
{
    class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(c => c.BrandName).NotEmpty();
            RuleFor(c => c.BrandName).MinimumLength(2);


          
        }
    }
}
