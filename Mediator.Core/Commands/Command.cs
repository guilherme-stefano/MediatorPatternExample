using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Core.Commands
{
    public class Command : Message, IRequest<ValidationResult>
    {
        public DateTime TimeStamp { get; private set ; }

        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            TimeStamp = DateTime.Now;
        }

        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
