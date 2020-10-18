using AltoBem.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AltoBem.API.Repositorie
{
    public static class ClienteRepositorie
    {
        public static ClienteDto criarUser(string nome, string sobrenome)
        {
            var users = new List<ClienteDto>();
            users.Add(new ClienteDto { Id = 1, Nome = "Thomaz", Sobrenome = "Peres", Role = "Manager" });
            return users.Where(x => x.Nome.ToLower() == nome.ToLower() && x.Sobrenome == sobrenome).FirstOrDefault();
        }
    }
}
