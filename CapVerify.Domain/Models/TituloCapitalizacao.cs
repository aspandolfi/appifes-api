using System;

namespace CapVerify.Domain.Models
{
    public class TituloCapitalizacao
    {
        public TituloCapitalizacao()
        {

        }

        public long TituloCaptalizacaoId { get; set; }

        public string Descricao { get; set; }

        public string Jogo { get; set; }

        public DateTime DataVencimento { get; set; }

        public DateTime DataSorteio { get; set; }

        public string UserId { get; set; }

        public virtual UserIdentity UserIdentity { get; set; }
    }
}
