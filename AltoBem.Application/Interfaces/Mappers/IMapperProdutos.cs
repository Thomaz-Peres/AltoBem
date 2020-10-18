using AltoBem.Application.Dtos;
using AltoBem.Domain.Entities;
using System.Collections.Generic;

namespace AltoBem.Application.Interfaces.Mappers
{
    public interface IMapperProdutos
    {
        Produtos MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produtos> produtos);
        ProdutoDto MapperEntityToDto(Produtos produtos);
    }
}
