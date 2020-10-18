using AltoBem.Domain.Core.Interfaces.Repositorys;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Infrastructure.Data.Repositorys
{
    public class RepositoryCategoria : RepositoryBase<Categoria>, IRepositoryCategoria
    {

        private readonly DataContext dataContext;
        public RepositoryCategoria(DataContext dataContext) : base(dataContext) => this.dataContext = dataContext;
    }
}
