using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces.Mappers;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltoBem.Application.Mappers
{
    public class MapperCategoria : IMapperCategoria
    {
        public Categoria MapperDtoToEntity(CategoriaDto categoriaDto)
        {
            var categoria = new Categoria()
            {
                Id = categoriaDto.Id,
                Titulo = categoriaDto.Titulo
            };

            return categoria;
        }

        public CategoriaDto MapperEntityToDto(Categoria categoria)
        {
            var categoriaDto = new CategoriaDto()
            {
                Id = categoria.Id,
                Titulo = categoria.Titulo,
            };

            return categoriaDto;
        }

        public IEnumerable<CategoriaDto> MapperListCategoriaDto(IEnumerable<Categoria> categorias)
        {
            var dto = categorias.Select(x => new CategoriaDto
            {
                Id = x.Id,
                Titulo = x.Titulo,
            });

            return dto;
        }
    }
}
