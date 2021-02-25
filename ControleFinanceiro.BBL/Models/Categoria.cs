using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro.BBL.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Icone { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }

        public ICollection<Ganho> Ganhos { get; set; }
        public ICollection<Despesa> Despesas { get; set; }
    }
}
