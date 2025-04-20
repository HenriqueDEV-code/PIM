using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade
{
    public class Funcionarios
    {
        public int UID_Funcionario { get; set; }  // Matricula do Funcionario
        public string NomeCompleto_Funcionario { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Cargo { get; set; }
        public DateTime Data_Admissao { get; set; }
        public string Salario { get; set; }
        public string Status { get; set; }  // true = Ativo || false = Inativo
        public string Senha { get; set; }

    }
}




