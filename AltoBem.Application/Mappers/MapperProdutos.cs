using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces.Mappers;
using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AltoBem.Application.Mappers
{
    public class MapperProdutos : IMapperProdutos
    {
        public Produtos MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produtos()
            {
                Id = produtoDto.Id,
                Titulo = produtoDto.Titulo,
                Descriçao = produtoDto.Descriçao,
                Preco = produtoDto.Preco,
                CategoriaId = produtoDto.CategoriaId
            };
            return produto;
        }



        public ProdutoDto MapperEntityToDto(Produtos produtos)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produtos.Id,
                Titulo = produtos.Titulo,
                Descriçao = produtos.Descriçao,
                Preco = produtos.Preco,
                CategoriaId = produtos.CategoriaId
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produtos> produtos)
        {
            var dto = produtos.Select(x => new ProdutoDto
            {
                Id = x.Id,
                Titulo = x.Titulo,
                Descriçao = x.Descriçao,
                Preco = x.Preco,
                CategoriaId = x.CategoriaId
            });

            return dto;
        }
    }
}
