using AltoBem.Application.Dtos;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Application.Interfaces.Mappers
{
    public interface IMapperCategoria
    {
        Categoria MapperDtoToEntity(CategoriaDto categoriaDto);
        IEnumerable<CategoriaDto> MapperListCategoriaDto(IEnumerable<Categoria> categorias);
        CategoriaDto MapperEntityToDto(Categoria categoria);
    }
}
