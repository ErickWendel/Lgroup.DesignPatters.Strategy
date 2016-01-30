using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy;
using LGroup.Strategy.Model;

namespace LGroup.Strategy.Business
{
    //Desconto de Valor * 2 - 20%
    public sealed class BlackFridayBusiness : IDescontoStrategy
    {
        //Agora essa 
        public decimal CalcularDesconto(decimal valor_)
        {
            return ((valor_ * 2) * 20) / 100;

        }
    }
}
