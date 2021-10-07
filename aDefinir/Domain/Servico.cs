using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDefinir.Domain
{
    class Servico
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double TempoServico { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public ICollection<Agendamento> Agendamento { get; set; }
    }
}
