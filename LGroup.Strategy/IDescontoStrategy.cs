using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Strategy
{

    //Bolamos uma estratégia de descontos em valores de produtos
    //de acordo com a data festiva
    //Natal = Valor - 20%
    //Dia da Maes = Valor - 10%
    //Black Friday = Valor + 20%

    public interface IDescontoStrategy
    {
        Decimal CalcularDesconto(Decimal valor_);
    }
}
