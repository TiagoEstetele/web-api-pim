namespace TESTE_API.ViewModel
{
    public class FuncionariosViewModel
    {
        public int id_funcionario { get; set; }
        public int id_cargo { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public DateOnly data_admissao { get; set; }
        public string ctps { get; set; }
        public float salario_bruto { get; set; }
        public DateOnly data_nascimento { get; set; }
        public string banco { get; set; }
        public string conta { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public bool ativo { get; set; }
        public string nome_social { get; set; }
        public string genero { get; set; }
    }
}
