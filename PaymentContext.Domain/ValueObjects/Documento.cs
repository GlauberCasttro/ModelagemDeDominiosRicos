using Flunt.Validations;
using PaymentContent.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

//O modelo VO(value Objects) são obetos de valores que compoem as entindades 
//o que diferencia um VO para uma entidade é que o VO nao tem Id 
//ou seja não irá virar uma entidade no sistema nem na base de dados
namespace PaymentContent.Domain.ValueObjects
{

   public class Documento : ValueObject 
    {

        public string NumeroDocumento { get; set; }
        public EDocumentType TipoDocumento { get; set; }
        public Documento(string numeroDocumento, EDocumentType tipoDocumento)
        {
         
            NumeroDocumento = numeroDocumento;
            TipoDocumento = tipoDocumento;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(ValidarTipos(), "Documento.TipoDocumento","Documento invalido")
                ) ;
        }


        //Não está validando os documentos, apenas para amostragem de utilização de codigo
        private bool ValidarTipos()
        {
            if (TipoDocumento == EDocumentType.CNPJ && NumeroDocumento.Length == 14)
                return true;
            else if (TipoDocumento == EDocumentType.CPF && NumeroDocumento.Length == 11)
                return true;
            return false;
        }

    }
}
