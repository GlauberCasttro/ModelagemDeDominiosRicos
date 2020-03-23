using PaymentContent.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Domain.ValueObjects
{
    public class Email : ValueObject
    {

        public string EnderecoEmail { get; set; }
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;
        }

    }
}
