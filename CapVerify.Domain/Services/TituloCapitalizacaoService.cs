using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Interfaces.Services;
using CapVerify.Domain.Models;

namespace CapVerify.Domain.Services
{
    public class TituloCapitalizacaoService : Service<TituloCapitalizacao>, ITituloCapitalizacaoService
    {
        private readonly ITituloCaptalizacaoRepository _tituloCaptalizacaoRepository;
        private readonly IUserRepository _userRepository;

        public TituloCapitalizacaoService(ITituloCaptalizacaoRepository tituloCaptalizacaoRepository,
                                          IUserRepository userRepository,
                                          IUnitOfWork unitOfWork)
            : base(tituloCaptalizacaoRepository, unitOfWork)
        {
            _tituloCaptalizacaoRepository = tituloCaptalizacaoRepository;
            _userRepository = userRepository;
        }
    }
}
