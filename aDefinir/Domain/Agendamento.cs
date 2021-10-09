using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDefinir.Domain
{
    class Agendamento
    {
        [Key]
        public int Codigo { get; set; }
        public string DataAg { get; set; }
        public string Hora { get; set; }
        public string Situacao { get; set; }
        public Carro Carro { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Servico> Servico { get; set; }
    }
}
