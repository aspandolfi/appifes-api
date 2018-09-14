using System.Linq;
using CapVerify.Api.ViewModels;
using CapVerify.Domain.Interfaces;
using CapVerify.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CapVerify.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TituloController : ControllerBase
    {
        readonly IUserRepository userRepository;
        readonly ITituloCaptalizacaoRepository tituloCaptalizacaoRepository;
        readonly IUser user;
        public TituloController(IUserRepository userRepository,
                                ITituloCaptalizacaoRepository tituloCaptalizacaoRepository,
                                IUser user)
        {
            this.userRepository = userRepository;
            this.tituloCaptalizacaoRepository = tituloCaptalizacaoRepository;
            this.user = user;
        }

        // GET api/titulo
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tituloCaptalizacaoRepository.GetAll().ToList());
        }

        [HttpGet]
        [Route("mine")]
        public IActionResult GetMine()
        {
            return Ok(tituloCaptalizacaoRepository.GetAll(x => x.UserIdentity.UserName == user.Name).ToList());
        }

        // POST api/titulo
        [HttpPost]
        public IActionResult Post([FromBody]TituloCapitalizacaoViewModel item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            var dbUser = userRepository.GetByEmail(user.Name);

            var titulo = new TituloCapitalizacao
            {
                Descricao = item.Descricao,
                DataSorteio = item.DataSorteio,
                Jogo = item.Jogo,
                DataVencimento = item.DataVencimento,
                UserId = dbUser.Id,
                UserIdentity = dbUser
            };

            tituloCaptalizacaoRepository.Add(titulo);

            item.UserId = dbUser.Id;

            return Ok(item);
        }
    }
}