using System;

namespace MinhasEconomias.Models
{
    public class Renda
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Periodo { get; set; }
        
        public Usuario Usuario { get; set; }
    }
}
