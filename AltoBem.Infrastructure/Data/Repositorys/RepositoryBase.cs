using AltoBem.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AltoBem.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DataContext dataContext;

        public RepositoryBase(DataContext _dataContext) => this.dataContext = _dataContext;

        public void Add(TEntity obj)
        {
            try
            {
                dataContext.Set<TEntity>().Add(obj);
                dataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Erro ao adicionar objeto");
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dataContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                dataContext.Set<TEntity>().Remove(obj);
                dataContext.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception($"Erro ao excluir objeto");
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                dataContext.Entry(obj).State = EntityState.Modified;
                dataContext.SaveChanges();

            }
            catch (Exception)
            {

                throw new Exception("Erro ao atualizar objeto");
            }
        }
    }
}
