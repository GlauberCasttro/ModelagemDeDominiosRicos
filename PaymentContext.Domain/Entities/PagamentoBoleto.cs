using PaymentContent.Domain.ValueObjects;
using System;
namespace PaymentContent.Domain.Entities
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(string codigoDeBarras, 
            string numeroDoBoleto, 
            DateTime dataPagamento, 
            DateTime dataExpiracaoPagamento, 
            DateTime total, string proprietario, 
            DateTime totalpago,
            Endereco enderecoCobranca,
            Email email,
            Documento documento) 
            : base(dataPagamento, dataExpiracaoPagamento,  total, proprietario, totalpago, enderecoCobranca, email, documento)
        {
            CodigoDeBarras = codigoDeBarras;
            NumeroDoBoleto = numeroDoBoleto;
        }

        public string CodigoDeBarras { get; private set; }
        public string NumeroDoBoleto { get; private set; }

    }
}
