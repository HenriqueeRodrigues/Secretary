using Business.InterfaceProduto;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.Produto;

namespace Data.ProdutoRepositorio
{
    public class RepositorioProduto : RepositoryGenerics<ProdutoViewModel>, IProduto
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioProduto()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

    }
}
