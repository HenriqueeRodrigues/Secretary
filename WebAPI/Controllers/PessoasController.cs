using Business.InterfacePessoa;
using Microsoft.AspNetCore.Mvc;
using Model.Pessoa;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : Controller
    {

        private readonly IPessoa _IPessoa;

        public PessoasController (IPessoa IPessoa)
        {
            _IPessoa = IPessoa;
        }

        [HttpGet("ListarPessoas")]
        public async Task<IActionResult> ListarPessoas()
        
        {
            return Json(await _IPessoa.List());
        }

        [HttpPost("ObterPessoaPorId")]
        public async Task<IActionResult> ObterPessoaPorId(int Id)
        {
            return Json(await _IPessoa.GetEntityById(Id));
        }

        [HttpPost("AdicionarPessoas")]
        public async Task AdicionarPessoas(PessoaViewModel pessoa)
        {
            await _IPessoa.Add(pessoa);
        }

        [HttpPost("AtualizarPessoas")]
        public async Task AtualizarPessoas(PessoaViewModel pessoa)
        {
            await _IPessoa.Update(pessoa);
        }

        [HttpPost("RemoverPessoas")]
        public async Task RemoverPessoas(PessoaViewModel pessoa)
        {
            await _IPessoa.Delete(pessoa);
        }
    }
}
