using Microsoft.AspNetCore.Mvc;
using TESTE_API.Model;
using TESTE_API.ViewModel;

namespace TESTE_API.Controllers
{
    [ApiController]
    [Route("api/v1/funcionarios")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionariosRepository _funcionariosRepository;

        public FuncionariosController(IFuncionariosRepository funcionariosRepository)
        {
            _funcionariosRepository = funcionariosRepository;
        }

        [HttpPost]

        public IActionResult Add(FuncionariosViewModel funcionariosView)
        {
            var funcionarios = new Funcionarios(funcionariosView.id_funcionario, funcionariosView.id_cargo, funcionariosView.nome, funcionariosView.telefone, funcionariosView.data_admissao, funcionariosView.ctps, funcionariosView.salario_bruto, funcionariosView.data_nascimento, funcionariosView.banco, funcionariosView.conta, funcionariosView.cpf, funcionariosView.email, funcionariosView.ativo, funcionariosView.nome_social, funcionariosView.genero, funcionariosView.endereco);
            _funcionariosRepository.Add(funcionarios);

            return Ok(); 
        }

        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = _funcionariosRepository.Get();

            return Ok(funcionarios);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionariosRepository.Delete(id);

            return Ok();
        }
    }
}
