using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapVerify.Api.Models
{
    public class TituloCaptalizacao
    {
        public TituloCaptalizacao()
        {

        }

        public int TituloCaptalizacaoId { get; set; }
        public string Descricao { get; set; }
        public string Jogo { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataSorteio { get; set; }
    }
}
