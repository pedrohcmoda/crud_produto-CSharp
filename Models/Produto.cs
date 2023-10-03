using Microsoft.EntityFrameworkCore;

namespace BootCamp.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public required string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}


