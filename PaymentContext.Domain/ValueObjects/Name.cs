using PaymentContent.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Name(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            if (string.IsNullOrEmpty(Nome))
                AddNotification("NomeEstudante.Nome", "Nome invalido");
        }

        
    }
}
 