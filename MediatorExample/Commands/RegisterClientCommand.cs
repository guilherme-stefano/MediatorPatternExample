using Mediator.Core.Commands;
using MediatorExample.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Commands
{
    public class RegisterClientCommand : Command
    {

        public Guid Id { get; private set; }
        public  string Name { get; private set; }
        public string Email { get; private set; }

        public RegisterClientCommand(Guid id, string name, string email)
        {
            AggregatedId = id;
            Id = id;
            Name = name;
            Email = email;
        }

        public override bool IsValid()
        {
            ValidationResult = new RegisterClientValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
