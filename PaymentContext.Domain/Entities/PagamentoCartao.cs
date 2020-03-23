using PaymentContent.Domain.ValueObjects;
using System;

namespace PaymentContent.Domain.Entities
{
    public class PagamentoCartao : Pagamento
    {
        public PagamentoCartao(string titularDoCartao, 
            string numeroCartao, 
            string numeroDaUltimaTransacaoCartao,
            DateTime dataPagamento, 
            DateTime dataExpiracaoPagamento, 
            DateTime total, 
            string proprietario, 
            DateTime totalpago,
            Endereco enderecoCobranca, 
            Email email, 
            Documento documento) 
            :base (dataPagamento, 
                 dataExpiracaoPagamento, 
                 total, 
                 proprietario, 
                 totalpago, 
                 enderecoCobranca, 
                 email, 
                 documento)
        {
            TitularDoCartao = titularDoCartao;
            NumeroCartao = numeroCartao;
            NumeroDaUltimaTransacaoCartao = numeroDaUltimaTransacaoCartao;
        }

        public string TitularDoCartao { get; private set; }
        public string NumeroCartao { get; private set; }
        public string NumeroDaUltimaTransacaoCartao { get; private set; }
    }
}
