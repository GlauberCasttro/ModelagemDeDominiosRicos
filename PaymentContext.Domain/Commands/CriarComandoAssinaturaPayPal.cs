using PaymentContent.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Domain.Commands
{
    public class CriarComandoAssinaturaPayPal
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string codigoDaTransacao { get; set; }
        public string NumeroPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracaoPagamento { get; set; }
        public decimal Total { get; set; }
        public string Proprietario { get; set; }
        public decimal Totalpago { get; set; }
        public Email EmailPagante { get; set; }
        public string DocumentoPagador { get; set; }
        public EDocumentType TipoDocumentoPagador { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string LocalReferencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
    }
}
