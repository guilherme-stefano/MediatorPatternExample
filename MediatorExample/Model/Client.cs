using MediatorExample.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Model
{
    public class Client : IAggregateRoot
    {

        public  Guid Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }

        protected Client() { }
        public Client(Guid id, string name, string secondName, string email)
        {
            Id = id;
            Name = name;
            SecondName = secondName;
            Email = email;
        }
    }
}
