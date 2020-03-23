using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContent.Domain.Entities;
using PaymentContent.Domain.ValueObjects;
using System;

namespace PaymentContent.Tests
{
    [TestClass]
    public class EstudandeTestes
    {
        [TestMethod]
        public void TestMethod1()
        {
            var assin = new Assinatura(DateTime.Now);
            
        }
    }
}
