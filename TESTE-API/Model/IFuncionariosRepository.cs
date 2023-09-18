using TESTE_API.Entities;

namespace TESTE_API.Model
{
    public interface IFuncionariosRepository
    {
        void Add(Funcionarios funcionarios);
        void Delete(int id);
        List<Funcionarios> Get();
        object GetFuncionarioById(int id);
        void Update(Funcionarios funcionario);
        Funcionarios GetFuncionarioByEmail(string email);
    }
}
