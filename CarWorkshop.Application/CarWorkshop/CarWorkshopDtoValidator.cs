using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarWorkshop.Domain.Inferfaces;

using FluentValidation;

namespace CarWorkshop.Application.CarWorkshop
{
    public class CarWorkshopDtoValidator : AbstractValidator<CarWorkshopDto>
    {
        public CarWorkshopDtoValidator(ICarWorkshopRepository repository)
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MinimumLength(2).WithMessage("Name should have atleast 2 characters")
                .MaximumLength(20).WithMessage("Name should have maxium of 20 characters")
                 .Custom((value, context) =>
                 {
                     var existingCarWorkshop = repository.GetByName(value).Result;
                     if (existingCarWorkshop != null)
                     {
                         context.AddFailure($"{value} is not unique name for car workshop");
                     }
                 }); ;

            RuleFor(c => c.Description)
                .NotEmpty();

            RuleFor(c => c.PhoneNumber)
            .Matches(@"^\+?[0-9]+$").WithMessage("Phone number must contain only digits.")
            .MinimumLength(8)
            .MaximumLength(12);
         
                
        }
    }
}
