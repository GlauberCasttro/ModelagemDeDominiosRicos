using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContent.Domain.Entities;
using PaymentContent.Domain.ValueObjects;
using System;

namespace PaymentContent.Tests
{
    [TestClass]
    public class EstudandeTestes
    {
        private readonly Name _name;
        private readonly Documento _documento;
        private readonly Endereco _endereco;
        private readonly Email _email;
        private readonly Estudante _estudante;
        private readonly Assinatura _assinatura;

        public EstudandeTestes()
        {
             _name = new Name("Glauber", "Castro");
             _documento = new Documento("10742473619", EDocumentType.CPF);
             _email = new Email("Glaubercastrro@gmail.com");
             _estudante = new Estudante(_name, _documento, _email);
             _assinatura = new Assinatura(null);
             _endereco = new Endereco("Rua 1", "1234", "Praca Raul", "Barro preto", "Belo Horizonte", "Brasil", "30170110");
          
        }

        [TestMethod]
        public void RetornaErroQuandoTemAssinaturaAtiva()

        {
            var pagamento = new PagamentoPayPal("123456", DateTime.Now, DateTime.Now.AddDays(5), 10, "Glauber", 10, _endereco, _email, _documento);


            var subscription = new Assinatura(null);
            subscription.AdcionarPagamento(pagamento);

            _estudante.AdcionarAssinatura(subscription);
            _estudante.AdcionarAssinatura(subscription);

            Assert.IsTrue(_estudante.Invalid);

        }

        [TestMethod]
        public void RetornaSucessoQuandoAddAssinatura()

        {
            var subscription = new Assinatura(null);
            var pagamento = new PagamentoPayPal("123456", DateTime.Now, DateTime.Now.AddDays(5), 10, "Glauber", 10, _endereco, _email, _documento);
            subscription.AdcionarPagamento(pagamento);
            _estudante.AdcionarAssinatura(subscription);
            Assert.IsTrue(_estudante.Valid);

        }

        [TestMethod]
        public void RetornaErroQuandoTemAssinaturaNaoTemPagamento()
        {
          
            _estudante.AdcionarAssinatura(_assinatura);
            Assert.IsTrue(_estudante.Invalid);
        }
       
    }
}
