using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Core.Commands
{
    public abstract class Command : Message, IRequest<ValidationResult>
    {
        public DateTime TimeStamp { get; private set ; }

        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
