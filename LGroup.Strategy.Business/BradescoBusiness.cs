using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy.Model;
using LGroup.Strategy;

namespace LGroup.Strategy.Business
{

    //Modelamos um componente de negocio multibanco
    //um componente com regras flexiveis pra qualquer instituicao financeira
    //atraveés do padrao STRATEGY
    //Terminamos a familia (Classe filha)

    public sealed class BradescoBusiness : IValidacaoStrategy
    {
        public void ValidarComposObrigatorios(Model.ClienteModel cliente_)
        {
            if (String.IsNullOrWhiteSpace(cliente_.Nome))
                throw new ApplicationException("Informe o Nome");

            if(String.IsNullOrWhiteSpace(cliente_.NumeroDocumento))
                throw new ApplicationException("Informe o Documento");
            
        }
    }
}
