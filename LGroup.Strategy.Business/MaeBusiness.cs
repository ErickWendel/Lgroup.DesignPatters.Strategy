using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy;
using LGroup.Strategy.Model;

namespace LGroup.Strategy.Business
{
    //Desconto 10%
    public sealed class MaeBusiness : IDescontoStrategy
    {
        public decimal CalcularDesconto(decimal valor_)
        {
            return (valor_ * 10) / 100;
        }
    }
}
