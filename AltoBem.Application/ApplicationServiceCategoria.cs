using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces;
using AltoBem.Application.Interfaces.Mappers;
using AltoBem.Application.Mappers;
using AltoBem.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Application
{
    public class ApplicationServiceCategoria : IApplicationServiceCategoria
    {
        private readonly IServiceCategoria serviceCategoria;
        private readonly IMapperCategoria mapperCategoria;

        public ApplicationServiceCategoria(IServiceCategoria serviceCategoria, IMapperCategoria mapperCategoria)
        {
            this.serviceCategoria = serviceCategoria;
            this.mapperCategoria = mapperCategoria;
        }

        public void Add(CategoriaDto categoriaDto)
        {
            var categoria = mapperCategoria.MapperDtoToEntity(categoriaDto);
            serviceCategoria.Add(categoria);
        }

        public IEnumerable<CategoriaDto> GetAll()
        {
            var categorias = serviceCategoria.GetAll();
            return mapperCategoria.MapperListCategoriaDto(categorias);
        }

        public CategoriaDto GetById(int id)
        {
            var categoria = serviceCategoria.GetById(id);
            return mapperCategoria.MapperEntityToDto(categoria);
        }

        public void Remove(CategoriaDto categoriaDto)
        {
            var categoria = mapperCategoria.MapperDtoToEntity(categoriaDto);
            serviceCategoria.Remove(categoria);
        }

        public void Update(CategoriaDto categoriaDto)
        {
            var categoria = mapperCategoria.MapperDtoToEntity(categoriaDto);
            serviceCategoria.Update(categoria);
        }
    }
}
