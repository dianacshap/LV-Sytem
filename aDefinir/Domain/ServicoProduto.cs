using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDefinir.Domain
{
    class ServicoProduto
    {
        [Key]
        public int Id { get; set; }
        public Servico Servico { get; set; }
        public Produto Produto { get; set; }
        public string Consumo { get; set; }


    }
}
