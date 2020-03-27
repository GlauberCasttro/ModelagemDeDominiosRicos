using Flunt.Validations;
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
        public decimal Total { get; private set; }
        public string Proprietario { get; private  set; }
        public decimal Totalpago { get; private set; }
        public Endereco EnderecoCobranca { get; private set; }
        public Email Email { get; private set; }
        public Documento Documento { get; set; }

        public Pagamento(DateTime dataPagamento, 
            DateTime dataExpiracaoPagamento,
            decimal total, string proprietario,
            decimal totalpago,
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

            AddNotifications(new Contract()
                .Requires()
                .IsLowerOrEqualsThan(0,Total, "Pagamento.Total", "O total nao pode ser 0")
                .IsGreaterOrEqualsThan(Total, Totalpago, "Pagamento.Total", "O total nao pode ser 0")
                );
        }

    }
}
