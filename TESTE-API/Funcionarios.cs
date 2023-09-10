using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace TESTE_API
{
    [Table("funcionarios")]
    public class Funcionarios
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }
        public string genero { get; set; }
        public float salario { get; set; }

        public Funcionarios(string nome, int idade, string cpf, float salario, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.salario = salario;
            this.genero = genero;
        }
    }
}