using TESTE_API.Entities;
using TESTE_API.Model;

namespace TESTE_API.Infraestrutura
{
    public class FuncionarioRepository : IFuncionariosRepository
    {

        private readonly PostgressContext _context = new PostgressContext();
        public void Add(Funcionarios funcionarios)
        {
            _context.Funcionarios.Add(funcionarios);
            _context.SaveChanges();
        }

        public Funcionarios GetFuncionarioByEmail(string email)
        {
            // Consulta o banco de dados para encontrar um funcionário com o email especificado
            return _context.Funcionarios.FirstOrDefault(f => f.email == email);
        }

        public List<Funcionarios> Get()
        {
            return _context.Funcionarios.ToList();
        }

        public void Delete(int funcionarioId)
        {
            var funcionarioToDelete = _context.Funcionarios.Find(funcionarioId);

            if (funcionarioToDelete != null)
            {
                _context.Funcionarios.Remove(funcionarioToDelete);
                _context.SaveChanges();
            }
        }

        public void Update(Funcionarios funcionario)
        {
            var existingFuncionario = _context.Funcionarios.Find(funcionario.id_funcionario);

            if (existingFuncionario != null)
            {
                existingFuncionario.id_funcionario = funcionario.id_funcionario;
                existingFuncionario.id_cargo = funcionario.id_cargo;
                existingFuncionario.nome = funcionario.nome;
                existingFuncionario.telefone = funcionario.telefone;
                existingFuncionario.data_admissao = funcionario.data_admissao;
                existingFuncionario.ctps = funcionario.ctps;
                existingFuncionario.salario_bruto = funcionario.salario_bruto;
                existingFuncionario.data_nascimento = funcionario.data_nascimento;
                existingFuncionario.banco = funcionario.banco;
                existingFuncionario.conta = funcionario.conta;
                existingFuncionario.cpf = funcionario.cpf;
                existingFuncionario.email = funcionario.email;
                existingFuncionario.ativo = funcionario.ativo;
                existingFuncionario.nome_social = funcionario.nome_social;
                existingFuncionario.genero = funcionario.genero;
                existingFuncionario.endereco = funcionario.endereco;

                _context.SaveChanges();
            }
        }
    }
}
