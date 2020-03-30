using PaymentContent.Domain.ValueObjects;
using PaymentContent.Shared.Commands;
using System;
using Flunt.Notifications;
using System.Collections.Generic;
using System.Text;
using Flunt.Validations;

namespace PaymentContent.Domain.Commands
{
    public class CriarComandoAssinaturaBoleto : Notifiable, ICommand 
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string CodigoDeBarras { get; set; }
        public string NumeroDoBoleto { get; set; }
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

       public void Validate()
        {
            //Validacoes com flunt balta.io
            //using Flunt.Validations;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Nome, 6, "Name.Nome", "Nome deve ter no minimo 6 caracteres")
                .HasMinLen(Sobrenome, 4, "Name.Sobrenome", "Sobrenome deve ter no minimo 4 caracteres")
                );
        }
    }
}
