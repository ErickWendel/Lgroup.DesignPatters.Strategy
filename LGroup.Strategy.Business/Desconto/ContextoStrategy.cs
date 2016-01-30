using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy;
using LGroup.Strategy.Model;
using LGroup.Strategy.Business;
namespace LGroup.Strategy.Business.Desconto
{
    public sealed class ContextoStrategy
    {
        private IDescontoStrategy _desconto;
        public ContextoStrategy(IDescontoStrategy desconto_)
        {
            this._desconto = desconto_;
        }
        public void Calcular(Decimal valor_)
        {

            _desconto.CalcularDesconto(valor_);
        }
    }
}
