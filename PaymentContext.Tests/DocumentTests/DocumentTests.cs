using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContent.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Tests.DocumentTests
{

    [TestClass]
    public class DocumentTests
    {


        //Metodologia para escrever bons testes
        // Red, green, refactor
        [TestMethod]
        public void RetornarErroQuandoCNPJINvalido()
        {
            //Falha no teste

            var document = new Documento("123", EDocumentType.CNPJ);
            Assert.IsTrue(document.Invalid);
            //Assert.Fail();

        }
        [TestMethod]
        public void RetornarErroQuandoCNPJValido()
        {
            //Falha no teste
            var document = new Documento("12323548902838", EDocumentType.CNPJ);
            Assert.IsTrue(document.Valid);
           // Assert.Fail();
        }

        [TestMethod]
        public void RetornarErroQuandoCPFINvalido()
        {
            //Falha no teste
            var document = new Documento("123", EDocumentType.CPF);
            Assert.IsTrue(document.Invalid);
           //Assert.Fail();

        }
        [TestMethod]
        public void RetornarErroQuandoCPFValido()
        {
            //Falha no teste
            var document = new Documento("12325478524", EDocumentType.CPF);
            Assert.IsTrue(document.Valid);
            //Assert.Fail();
        }
        //forma para testar varios cps ao mesmo tempo
        [TestMethod]
        [DataTestMethod]
        [DataRow("90622729082")]
        [DataRow("90622729080")]
        [DataRow("88821328031")]
        [DataRow("60539549002")]
        public void RetornarVariosErroQuandoCPFValido(string cpf)
        {
            //Falha no teste
            var document = new Documento(cpf, EDocumentType.CPF);
            Assert.IsTrue(document.Valid);
            //Assert.Fail();
        }
    }
}
