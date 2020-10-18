using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces.Mappers;
using AltoBem.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AltoBem.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Role = clienteDto.Role
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clienteDto = new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Role = cliente.Role
            };

            return clienteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(x => new ClienteDto
            {
                Id = x.Id,
                Nome = x.Nome,
                Sobrenome = x.Sobrenome,
                Role = x.Role
            });

            return dto;
        }
    }
}
