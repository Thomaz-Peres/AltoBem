using AltoBem.Domain.Core.Interfaces.Repositorys;
using AltoBem.Domain.Core.Interfaces.Services;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;
        public ServiceCliente(IRepositoryCliente _repository) : base(_repository) =>  this.repositoryCliente = _repository;
    }
}
