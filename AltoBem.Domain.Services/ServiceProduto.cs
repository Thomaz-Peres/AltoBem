using AltoBem.Domain.Core.Interfaces.Repositorys;
using AltoBem.Domain.Core.Interfaces.Services;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produtos>, IServiceProduto
    {
        private readonly IRepositoryProdutos repositoryproduto;
        public ServiceProduto(IRepositoryProdutos _repository) : base(_repository)
        {
            this.repositoryproduto = _repository;
        }
    }
}
