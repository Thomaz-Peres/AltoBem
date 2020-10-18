using AltoBem.Domain.Core.Interfaces.Repositorys;
using AltoBem.Domain.Core.Interfaces.Services;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Domain.Services
{
    public class ServiceCategoria : ServiceBase<Categoria>, IServiceCategoria
    {
        private readonly IRepositoryCategoria repositoryCategoria;
        public ServiceCategoria(IRepositoryCategoria _repository) : base(_repository)
        {
            this.repositoryCategoria = _repository;
        }
    }
}
