using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AltoBem.API.Controllers
{
    [Route("categoria")]
    public class CategoriaController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult<IEnumerable<string>> GetAll([FromServices]IApplicationServiceCategoria serviceCategoria)
        {
            return Ok(serviceCategoria.GetAll());
        }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<IEnumerable<string>> GetById([FromServices] IApplicationServiceCategoria serviceCategoria, int id)
        {
            return Ok(serviceCategoria.GetById(id));
        }

        [HttpPost]
        [Route("")]
        public ActionResult Post([FromServices] IApplicationServiceCategoria serviceCategoria, [FromBody]CategoriaDto categoriaDto)
        {
            try
            {
                if (categoriaDto == null)
                    return NotFound(new { message = "Não foi possivel criar a categoria" });

                serviceCategoria.Add(categoriaDto);
                return Ok($"Categoria cadastrada com sucesso \n {categoriaDto}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("")]
        public ActionResult Put([FromServices] IApplicationServiceCategoria serviceCategoria, [FromBody] CategoriaDto categoriaDto)
        {
            try
            {
                if (categoriaDto == null)
                    return NotFound(new { message = "Não foi possivel alterar a categoria" });

                serviceCategoria.Update(categoriaDto);
                return Ok($"Categoria atualizada com sucesso \n {categoriaDto}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public ActionResult Delete([FromServices] IApplicationServiceCategoria serviceCategoria, [FromBody] CategoriaDto categoriaDto, int id)
        {
            try
            {
                if (id != categoriaDto.Id)
                    return NotFound(new { message = "Não foi possivel remover o usuario" });

                serviceCategoria.Remove(categoriaDto);
                return Ok("Cliente removido com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
