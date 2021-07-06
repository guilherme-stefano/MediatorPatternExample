using MediatorExample.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Model
{
    public class Client : IAggregateRoot
    {
        public  int Id { get; set; }

        public string Name { get; set; }

        public string SecondName { get; set; }

        public string Email { get; set; }
    }
}
