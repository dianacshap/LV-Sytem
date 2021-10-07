using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDefinir.Domain
{
    class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public double Custo { get; set; }
        public double Volume { get; set; }
        public double Diluicao { get; set; }
        public ICollection<Servico> Servicos { get; set; }
    }
}
