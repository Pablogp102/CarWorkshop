using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentValidation;

namespace CarWorkshop.Application.CarWorkshop.Commands.EditCarWorkshop
{
    public class EditCarWorkshopCommandValidator : AbstractValidator<EditCarWorkshopCommand>
    {
        public EditCarWorkshopCommandValidator()
        {
            RuleFor(c => c.Description)
                .NotEmpty().WithMessage("The description is reqiuired");

            RuleFor(c => c.PhoneNumber)
                .MinimumLength(8)
                .MaximumLength(12)
                .Matches(@"^\+?[0-9]+$")
                .WithMessage("Phone number must contain only digits.");
        }
    }
}
