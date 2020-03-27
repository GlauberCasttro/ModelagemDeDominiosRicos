using PaymentContent.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using PaymentContent.Shared.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;

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
            //foreach (var ass in Assinaturas)
            //{
            //    ass.Desativa();
            //}
            //_assinaturas.Add(assinatura);


           
            var TemAssinaturasAtiva = false;
            foreach (var ass in _assinaturas)
            {
                if (ass.Ativo)
                    TemAssinaturasAtiva = true;
            }

            //Alternativa A para usar com Flunt Contract
          AddNotifications(new Contract()
                .Requires()
                .IsFalse(TemAssinaturasAtiva, "Estudante.Assinaturas", "Você já tem uma assinatura ativa")
                .AreNotEquals(0,assinatura.Pagamento.Count, "Estudante.Assinaturas", "Essa assinatura nao há nenhum pagamento"));


            if (Valid)
            {
                _assinaturas.Add(assinatura);
            }

            //Alternativa B para nao usar o contract do Flunt
            //if (TemAssinaturasAtiva)
            //{
            //    AddNotification("Estudante.Assinaturas", "Voce ja tem assinatura ativa");
            //}
        }

    }
}
