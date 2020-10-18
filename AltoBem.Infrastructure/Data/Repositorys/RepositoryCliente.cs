using AltoBem.Domain.Core.Interfaces.Repositorys;
using AltoBem.Domain.Entities;

namespace AltoBem.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly DataContext dataContext;

        public RepositoryCliente(DataContext dataContext) : base(dataContext) => this.dataContext = dataContext;
    }
}
