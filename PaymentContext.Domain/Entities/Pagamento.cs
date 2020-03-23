using PaymentContent.Domain.ValueObjects;
using PaymentContent.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Domain.Entities
{
    public abstract class Pagamento : Entity
    {
        public string NumeroPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpiracaoPagamento { get; private set; }
        public DateTime Total { get; private set; }
        public string Proprietario { get; private  set; }
        public DateTime Totalpago { get; private set; }
        public Endereco EnderecoCobranca { get; private set; }
        public Email Email { get; private set; }
        public Documento Documento { get; set; }

        protected Pagamento(DateTime dataPagamento, 
            DateTime dataExpiracaoPagamento,
            DateTime total, string proprietario,
            DateTime totalpago,
            Endereco enderecoCobranca, 
            Email email, 
            Documento documento)
        {
            NumeroPagamento = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpiracaoPagamento = dataExpiracaoPagamento;
            Total = total;
            Proprietario = proprietario;
            Totalpago = totalpago;
            EnderecoCobranca = enderecoCobranca;
            Email = email;
            Documento = documento;
        }

    }
}
