using System.Collections.Generic;

namespace MinhasEconomias.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public IList<Renda> Rendas { get; set; }
        public IList<Despesa> Despesas { get; set; }

        public Usuario()
        {
            Despesas = new List<Despesa>();
            Rendas = new List<Renda>();
        }


    }
}
