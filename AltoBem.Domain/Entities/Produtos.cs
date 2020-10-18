using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AltoBem.Domain.Entities
{
    public class Produtos : Base
    {
        [Required(ErrorMessage = "Favor adicionar um titulo do produto")]
        public string Titulo { get; set; }
        [MaxLength(160, ErrorMessage = "Maximo de 160 caracteres")]
        public string Descriçao { get; set; }
        [Required(ErrorMessage = "Coloque um preço no seu produto")]
        public decimal Preco { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
