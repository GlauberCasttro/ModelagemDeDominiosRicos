using Flunt.Validations;
using PaymentContent.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(string rua, string numero, string localReferencia, string bairro, string cidade, string pais, string cep)
        {
            Rua = rua;
            Numero = numero;
            LocalReferencia = localReferencia;
            Bairro = bairro;
            Cidade = cidade;
            Pais = pais;
            Cep = cep;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Rua, 4, "Endereco.Rua", "A rua só pode ter  caracteres")
                );
        }

        public string Rua { get; private set; }
        public string Numero  { get; private set; }
        public string LocalReferencia { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }


    }
}
