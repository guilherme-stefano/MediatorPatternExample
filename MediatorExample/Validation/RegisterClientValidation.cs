using FluentValidation;
using MediatorExample.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MediatorExample.Validation
{
    public class RegisterClientValidation : AbstractValidator<RegisterClientCommand>
    {
        public RegisterClientValidation()
        {
            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty)
                .WithMessage("Id is Required");

            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()  
                .WithMessage("Name is Required");

            RuleFor(c => c.Email)
                .Must(ValidMail)
                .WithMessage("Name is Required");
        }

        protected static bool ValidMail(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);

        }
    }
}
