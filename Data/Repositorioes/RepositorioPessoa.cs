using Business.InterfacePessoa;
using Data.Config;
using Data.RepositorioGenerico;
using Microsoft.EntityFrameworkCore;
using Model.Pessoa;

namespace Data.PessoaRepositorio
{
    public class RepositorioPessoa : RepositoryGenerics<PessoaViewModel>, IPessoa
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioPessoa()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

    }
}
