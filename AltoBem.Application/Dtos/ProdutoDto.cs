using AltoBem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AltoBem.Application.Dtos
{
    public class ProdutoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descriçao { get; set; }
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}
