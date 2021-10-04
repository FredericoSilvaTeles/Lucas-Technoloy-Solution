using LucasTechnologyServices.Module.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Services.Api.ViewModels
{
    public class CustomerForm
    {
        public long Id { get; set; }
        public string Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public bool IsActive { get; set; }
    }
}
