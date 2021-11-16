using Business.InterfaceProduto;
using Microsoft.AspNetCore.Mvc;
using Model.Produto;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : Controller
    {

        private readonly IProduto _IProduto;

        public ProdutosController (IProduto IProduto)
        {
            _IProduto = IProduto;
        }

        [HttpGet("ListarProdutos")]
        public async Task<IActionResult> ListarProdutos()
        {
            return Json(await _IProduto.List());
        }


        [HttpPost("ObterProdutoPorId")]
        public async Task<IActionResult> ObterProdutoPorId(int Id)
        {
            return Json(await _IProduto.GetEntityById(Id));
        }

        [HttpPost("AdicionarProdutos")]
        public async Task AdicionarProdutos(ProdutoViewModel produto)
        {
            await _IProduto.Add(produto);
        }

        [HttpPost("AtualizarProdutos")]
        public async Task AtualizarProdutos(ProdutoViewModel produto)
        {
            await _IProduto.Update(produto);
        }

        [HttpPost("RemoverProdutos")]
        public async Task RemoverProdutos(ProdutoViewModel produto)
        {
            await _IProduto.Delete(produto);
        }
    }
}
