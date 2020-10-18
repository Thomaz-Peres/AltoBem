using AltoBem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Application.Interfaces
{
    public interface IApplicationServiceCategoria
    {
        void Add(CategoriaDto categoriaDto);
        void Update(CategoriaDto categoriaDto);
        void Remove(CategoriaDto categoriaDto);
        IEnumerable<CategoriaDto> GetAll();
        CategoriaDto GetById(int id);
    }
}
