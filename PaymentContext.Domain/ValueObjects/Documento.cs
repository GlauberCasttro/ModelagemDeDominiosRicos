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
        public EDocumentFile TipoDocumento { get; set; }
        public Documento(string numeroDocumento, EDocumentFile tipoDocumento)
        {
         
            NumeroDocumento = numeroDocumento;
            TipoDocumento = tipoDocumento;
        }

    }
}
