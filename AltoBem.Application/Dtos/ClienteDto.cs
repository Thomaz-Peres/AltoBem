using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Application.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Role { get; set; }
    }
}
