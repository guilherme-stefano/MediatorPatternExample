using FluentValidation.Results;
using MediatorExample.Commands;
using MediatorExample.Data.Interfaces;
using MediatorExample.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorExample.Validation
{
    public class ClientCommandHandler : IRequestHandler<RegisterClientCommand, ValidationResult>
    {
        private readonly IClientRepository _clientRepository;
        protected ValidationResult ValidationResult;

        public ClientCommandHandler(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            ValidationResult = new ValidationResult();
        }

        public async Task<ValidationResult> Handle(RegisterClientCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsValid()) return request.ValidationResult;

            var client = new Client(request.Id, request.Name, request.Email);

            var emailClient = await _clientRepository.GetByMail(request.Email);

            if(emailClient != null)
            {
                GenerateError("Email already exists.");
                return this.ValidationResult;
            }

            _clientRepository.Add(client);

            var saved = await _clientRepository.SaveChanges();

            if (!saved) 
            {
                GenerateError("An error occurred while persisting data");
                return this.ValidationResult;
            }

            return this.ValidationResult;
        }

        private void GenerateError(string message)
        {
           this.ValidationResult.Errors.Add(new ValidationFailure(string.Empty, message));
        }
    }
}
