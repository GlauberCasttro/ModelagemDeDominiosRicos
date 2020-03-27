using PaymentContent.Domain.ValueObjects;
using System;
namespace PaymentContent.Domain.Entities
{
    public class PagamentoPayPal : Pagamento 
    {
        public PagamentoPayPal(string codigoDaTransacao,
            DateTime dataPagamento, 
            DateTime dataExpiracaoPagamento,
            decimal total, 
            string proprietario,
            decimal totalpago,
            Endereco enderecoCobranca,
            Email email, 
            Documento documento) 
            : base(dataPagamento,
                  dataExpiracaoPagamento,
                  total, proprietario,
                  totalpago,
                  enderecoCobranca, 
                  email, 
                  documento)
        {
            CodigoDaTransacao = codigoDaTransacao;
        }

        public string CodigoDaTransacao { get; private set; }
    }
}
