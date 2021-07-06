using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Core.Commands
{
    public class Message
    {
        public string MessageType { get; protected set; }

        public Guid AggregatedId { get; set; }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
