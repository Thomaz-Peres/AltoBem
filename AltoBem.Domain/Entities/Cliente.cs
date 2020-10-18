using System;
using System.ComponentModel.DataAnnotations;

namespace AltoBem.Domain.Entities
{
    public class Cliente : Base
    {
        [Required(ErrorMessage = "Favor colocar sue nome")]
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Role { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
