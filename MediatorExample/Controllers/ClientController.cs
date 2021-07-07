using Mediator.Core.Mediator;
using MediatorExample.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Controllers
{
    public class ClientController : MainController
    {
        private readonly IMediatorHandler _mediatorHandler;

        public ClientController(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }

        [HttpPost("client")]
        public async Task<IActionResult> Post()
        {
            var result = await _mediatorHandler.SendCommand(new RegisterClientCommand(Guid.NewGuid(), "test", "test@test.com"));
            return CustomResponse(result);
        }
    }
}
