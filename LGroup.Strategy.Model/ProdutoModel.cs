using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGroup.Strategy.Model
{
    public sealed class ProdutoModel
    {
        public Int32 Codigo { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }

        public Decimal Valor { get; set; }

    }
}
