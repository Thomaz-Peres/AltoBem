using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces;
using AltoBem.Application.Interfaces.Mappers;
using AltoBem.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Application
{
    public class ApplicationServiceProdutos : IApplicationServiceProduto
    {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProdutos mapperProduto;

        public ApplicationServiceProdutos(IServiceProduto serviceProduto, IMapperProdutos mapperProduto)
        {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutosDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(produto);
        }
    }
}
