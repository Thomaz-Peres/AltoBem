using System.ComponentModel.DataAnnotations;

namespace AltoBem.Domain.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
