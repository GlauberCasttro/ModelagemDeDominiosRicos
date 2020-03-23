using PaymentContent.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using PaymentContent.Shared.Entities;
using Flunt.Notifications;

namespace PaymentContent.Domain.Entities
{
    public class Estudante : Entity
    {

        private IList<Assinatura> _assinaturas;
        public Name NomeEstudante { get; set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }
        public Estudante(Name nome, Documento documento, Email email)
        {
            NomeEstudante = nome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();
            AddNotifications(nome, documento, email);
        }

        public void AdcionarAssinatura(Assinatura assinatura)
        {
            //Se já tiver um assinatura ativa, cancela a nova assinatura
            //ou
            //Cancela todas as outras e coloca a nova assinatura como principal
            foreach (var ass in Assinaturas)
            {
                ass.Desativa();
            }
            _assinaturas.Add(assinatura);
        }

    }
}
