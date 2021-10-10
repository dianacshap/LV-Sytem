using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDefinir.Domain
{
    class AgendamentosServicos
    {
        [Key]
        public int Id { get; set; }
        public Agendamento Agendamentos { get; set; }
        public Servico Servicos { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}
