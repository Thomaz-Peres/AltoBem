using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AltoBem.Application.Dtos;
using AltoBem.Application.Interfaces;
using AltoBem.Domain.Entities;
using AltoBem.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AltoBem.API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : Controller
    {
        ILogger _logger;
        public HomeController(ILogger<HomeController> logger) => _logger = logger;

        [HttpGet]
        [Route("")]
        public ActionResult Get([FromServices] IApplicationServiceCliente serviceCliente)
        {
            _logger.LogInformation("Cadastrando usuario");
            var home = new ClienteDto { Id = 1, Nome = "Thomaz", Sobrenome = "Peres", Role = "Manager"};
            serviceCliente.Add(home);

            return Ok(new { message = "Dados configurados" });
        }
    }
}
