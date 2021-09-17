using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aDefinir.Domain
{
    class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public double Celular { get; set; }
        public string Email { get; set; }
    }
}
