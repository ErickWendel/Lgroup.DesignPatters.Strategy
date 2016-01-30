using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy.Model;
using LGroup.Strategy;


namespace LGroup.Strategy.Business
{
   public sealed class CefBusiness : IValidacaoStrategy
    {
       public void ValidarComposObrigatorios(Model.ClienteModel cliente_)
       {
           if (String.IsNullOrWhiteSpace(cliente_.Nome))
               throw new ApplicationException("Informe o Nome");

           if (String.IsNullOrWhiteSpace(cliente_.NumeroDocumento))
               throw new ApplicationException("Informe o Documento");

           if (String.IsNullOrWhiteSpace(cliente_.Telefone))
               throw new ApplicationException("Informe o Telefone");

       }
    }
}
