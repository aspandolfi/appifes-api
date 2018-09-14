using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapVerify.Api.ViewModels
{
    public class TituloCapitalizacaoViewModel
    {
        public string Descricao { get; set; }

        public string Jogo { get; set; }

        public DateTime DataVencimento { get; set; }

        public DateTime DataSorteio { get; set; }

        public string UserId { get; set; }
    }
}
