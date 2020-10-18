using System;
using System.Collections.Generic;
using AltoBem.API.Repositorie;
using AltoBem.API.Services;
using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AltoBem.API.Controllers
{
    [Route("cliente")]
    public class ClienteController : Controller
    {
        ILogger _logger;
        public ClienteController(ILogger<ClienteController> logger) => _logger = logger;

        [HttpGet]
        [Route("")]
        [AllowAnonymous]
        public ActionResult<IEnumerable<string>> GetAll([FromServices]IApplicationServiceCliente serviceCliente)
        {
            _logger.LogInformation("Puxando dados de todos os cliente");
            return Ok(serviceCliente.GetAll());
        }

        [HttpGet]
        [Route("{id:int}")]
        [AllowAnonymous]
        public ActionResult<string> GetById([FromServices] IApplicationServiceCliente serviceCliente, int id)
        {
            return Ok(serviceCliente.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult Post([FromServices] IApplicationServiceCliente serviceCliente, [FromBody]ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound(new { message = "Não foi possivel criar o cliente" });

                serviceCliente.Add(clienteDto);
                return Ok($"Cliente cadastrado com sucesso \n {clienteDto}");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        [Route("")]
        [AllowAnonymous]
        public ActionResult Put([FromServices]IApplicationServiceCliente serviceCliente, [FromBody]ClienteDto clienteDto)
        {
            try
            {
                if (clienteDto == null)
                    return NotFound(new { message = "Não foi possivel alterar o cliente" });

                serviceCliente.Update(clienteDto);
                return Ok($"Cliente atualizado com sucesso \n {clienteDto}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        [AllowAnonymous]
        public ActionResult Delete([FromServices]IApplicationServiceCliente serviceCliente, [FromBody]ClienteDto clienteDto, int id)
        {
            try
            {
                if (id != clienteDto.Id)
                    return NotFound(new { message = "Não foi possivel remover o usuario" });

                serviceCliente.Remove(clienteDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult<dynamic> Login([FromServices] IApplicationServiceCliente serviceCliente, [FromBody]ClienteDto clienteDto)
        {
            var usuario = ClienteRepositorie.criarUser(clienteDto.Nome, clienteDto.Sobrenome);

            if (usuario == null)
                return NotFound(new { message = "Usuario ou senha invalidos" });

            var token = TokenService.GenerateToken(usuario);

            return new
            {
                usuario = usuario,
                token = token
            };
            //return Ok(new { message = "Login feito com sucesso" });
        }

    }
}
