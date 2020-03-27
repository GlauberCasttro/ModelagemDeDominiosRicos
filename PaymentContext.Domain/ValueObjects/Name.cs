using Flunt.Validations;
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


            //Validacoes com flunt balta.io
            //using Flunt.Validations;
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Nome, 6,"Name.Nome", "Nome deve ter no minimo 6 caracteres")
                .HasMinLen(Sobrenome, 4, "Name.Sobrenome", "Sobrenome deve ter no minimo 4 caracteres")

                );
        }

        
    }
}
 