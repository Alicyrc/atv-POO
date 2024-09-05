using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroFornecedores.Models
{
    internal class Fornecedores
    {
        public int Id_fornecedor { get; set; }
        public string Razao_social { get; set; }
        public string Nome_fornecedor { get; set; }
        public string Cnpj { get; set; }
        public bool Status_fornecedor { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
