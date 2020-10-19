using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AltoBem.API.Controllers
{
    [Route("produtos")]
    public class ProdutoController : Controller
    {
        ILogger _logger;
        public ProdutoController(ILogger<ProdutoController> logger) => _logger = logger;

        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> GetAll([FromServices] IApplicationServiceProduto serviceProduto)
        {
            _logger.LogInformation("Puxando todos os produtos cadastrados");
            return Ok(serviceProduto.GetAll());
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<string> GetById([FromServices] IApplicationServiceProduto serviceProduto, int id)
        {
            _logger.LogInformation("Puxando dados do produto");
            return Ok(serviceProduto.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult Post([FromServices] IApplicationServiceProduto serviceProduto, [FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if(produtoDto == null)
                    return NotFound(new { message = "Não foi possivel criar o produto" });

                _logger.LogInformation("Adicionando produto");

                serviceProduto.Add(produtoDto);
                return Ok($"Produto cadastrado com sucesso \n {produtoDto}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("")]
        public ActionResult<IEnumerable<string>> Put([FromServices] IApplicationServiceProduto serviceProduto, [FromBody] ProdutoDto produtoDto)
        {
            try
            {
                if(produtoDto == null)
                    return NotFound(new { message = "Não foi possivel alterar o produto" });

                _logger.LogInformation("Atualizando dados do produto");

                serviceProduto.Update(produtoDto);
                return Ok($"Produto atualizado com sucesso \n {produtoDto}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("")]
        public ActionResult Delete([FromServices] IApplicationServiceProduto serviceProduto, [FromBody]ProdutoDto produtoDto)
        {
            try
            {
                if (produtoDto == null)
                    return NotFound(new { message = "Não foi possivel remover o produto" });

                _logger.LogInformation("Deletando produto");

                serviceProduto.Remove(produtoDto);
                return Ok("O produto foi removido com sucesso");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
