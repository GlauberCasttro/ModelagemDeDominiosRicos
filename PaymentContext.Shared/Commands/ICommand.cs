using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentContent.Shared.Commands
{
   public interface ICommand
    {
        void Validate();
    }
}
