using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContent.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Tests.Commands
{

    [TestClass]
   public class CriarComandoAssinaturaTests
    {

        [TestMethod]
        public void RetornaErroQuandoNomeInavlido()
        {
            var command = new CriarComandoAssinaturaBoleto();
            command.Nome = "";
            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}
