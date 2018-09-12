using CapVerify.Data.Context;
using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Models;

namespace CapVerify.Data.Repositories
{
    public class TituloCapitalizacaoRepository : Repository<TituloCapitalizacao>, ITituloCaptalizacaoRepository
    {
        public TituloCapitalizacaoRepository(CapVerifyContext context) : base(context)
        {
        }
    }
}
