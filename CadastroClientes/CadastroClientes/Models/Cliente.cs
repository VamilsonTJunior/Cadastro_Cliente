using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
   
    [Table("cadastro_de_clientes")]
    public class Cliente
    {
        [Key]
        public int codigo { get; set; }

        public String nome { get; set; }

        public String cnpj { get; set; }

        public DateTime datacadastro { get; set; }

        public String endereco { get; set; }

        public String telefone { get; set; }


    }
}
