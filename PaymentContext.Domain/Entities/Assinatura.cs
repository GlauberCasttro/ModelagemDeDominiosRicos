using PaymentContent.Shared.Entities;
using System;
using System.Collections.Generic;
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
        public IReadOnlyCollection<Pagamento> Pagamento { get; private set; }
        public Assinatura(DateTime dataExpiracao)
        {
            DataCriacao = DateTime.Now; 
            DataUltimaAtualizacao = DateTime.Now;
            Ativo = true;
            DataExpiracao = dataExpiracao;
            _pagamentos = new List<Pagamento>();
        }

        public void AdcionarPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
        }

        public void Ativa()
        {
            Ativo = true;
            DataUltimaAtualizacao = DateTime.Now;
        }
        public void Desativa()
        {
            Ativo = false;
            DataUltimaAtualizacao = DateTime.Now;
        }

    }
}
