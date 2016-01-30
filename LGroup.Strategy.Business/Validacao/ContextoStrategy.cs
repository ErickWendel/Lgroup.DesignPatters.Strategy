using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy;
using LGroup.Strategy.Model;
using LGroup.Strategy.Business;
namespace LGroup.Strategy.Business.Validacao
{

    //A classe de conteto inicializa as estrategicas
    //cada estrategia tem sua propria classe de contexto
    //CONTEXTO (VALIDACAO)
    //CONTEXTO (DESCONTO)
    public sealed class ContextoStrategy
    {
        private IValidacaoStrategy _estrategiaValidacao;
        //Quem for adiciona essa classe (INJETA) paassa para dentro 
        //dela alguma estrategia de validacao (ItauBusiness, CefBusiness)
        //sempre deixar a interface, nunca colocar as classes filhas
        public ContextoStrategy(IValidacaoStrategy estrategiaValidacao_)
        {
            this._estrategiaValidacao = estrategiaValidacao_;
        }

        //criamos um comando para executar a estrategia de validacao
        public void Validar(ClienteModel cliente_)
        {
            _estrategiaValidacao.ValidarComposObrigatorios(cliente_);
        }

    }
}
