using PaymentContent.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public string Rua { get; private set; }
        public string Numero  { get; private set; }
        public string LocalReferencia { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }


    }
}
