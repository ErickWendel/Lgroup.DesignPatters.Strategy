using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy.Model;


namespace LGroup.Strategy
{
    // O padrao strategy serve para criar estrategias de codigo
    //de 1 a 5 = 4 - Muito Utilizado
    //Com este padrao conseguimos criar componenetes e classes flexiveis
    //que se adequem as necessidades do cliente
    //Exemplos clássicos
    //Estrategia (Vendas, Promocoes, Acesso a dados, regras de negocio, bancos)
    //Modelamos 1 MESMO COMPONENTE (1 DLL) para varios clientes
    //pra implementar o padrao temos que criar uma familia de algoritmos
    //INTERFACE PAI (Estrategia)
    //Varias classes filhas (Implementadas as estrategias)
    public interface IValidacaoStrategy
    {
        void ValidarComposObrigatorios(ClienteModel cliente_);


    }
}
