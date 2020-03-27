using Flunt.Validations;
using PaymentContent.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaymentContent.Domain.Entities
{
    public class Assinatura : Entity
    {
        private IList<Pagamento> _pagamentos;
        public DateTime DataCriacao { get; private set; }
        public DateTime DataUltimaAtualizacao { get; private set; }
        public DateTime? DataExpiracao { get; private set; }
        public bool Ativo { get; private set; }
        public IReadOnlyCollection<Pagamento> Pagamento { get  { return _pagamentos.ToArray(); } }
        public Assinatura(DateTime? dataExpiracao)
        {
            DataCriacao = DateTime.Now; 
            DataUltimaAtualizacao = DateTime.Now;
            Ativo = true;
            DataExpiracao = dataExpiracao;
            _pagamentos = new List<Pagamento>();
        }

        public void AdcionarPagamento(Pagamento pagamento)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, pagamento.DataPagamento, "Assinatura.Pagamento", "A data do pagamento nao pode ser menor que a data atual"));
         
            if(Valid)
            _pagamentos.Add(pagamento);
        }

        public void AtivaAssinatura()
        {
            Ativo = true;
            DataUltimaAtualizacao = DateTime.Now;
        }
        public void DesativaAssinatura()
        {
            Ativo = false;
            DataUltimaAtualizacao = DateTime.Now;
        }

    }
}
