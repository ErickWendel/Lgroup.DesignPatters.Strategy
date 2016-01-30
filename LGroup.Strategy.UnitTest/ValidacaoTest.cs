using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Strategy.Business;
using LGroup.Strategy.Business.Validacao;
using LGroup.Strategy.Model;

namespace LGroup.Strategy.UnitTest
{
    [TestFixture]
    public sealed class ValidacaoTest
    {
        [Test]
        public void Testar_Regras_Do_Itau_Com_Strategy()
        {
            //Levamos o sistema para rodar no itau
            //temos que acionar a estrategia de alidacao do itau
            var novoCliente = new ClienteModel();
            novoCliente.Nome = "Cliente 01";
            novoCliente.NumeroDocumento = "123123123";
            novoCliente.Telefone = "123123123";

            //acionamos a classe de contexto
            //a classe que inicializa uma determinadad classe de negocio
            var contexto = new ContextoStrategy(new ItauBusiness());
            contexto.Validar(novoCliente);

        }
        [Test]
        public void Testar_Regras_Do_Bradesco_Com_Strategy()
        {
           // existem 2 formas de acionar as DLLs e classes
            // 1 - EARLY BINDING
            // ADD REFERENCE sai dando new nas classes
            //conhecemos as dlls e classes em Modo de COMPLICAO

            // 2 - LATE BINDING
            //Quando acionamos as DLLs e classes dinamicamente
            //em modo de execucao. Quando usamos o Reflection
            var novoCliente = new ClienteModel();
            novoCliente.Nome = "Cliente 01";
            novoCliente.NumeroDocumento = "123123123";

            var contexto = new ContextoStrategy(new BradescoBusiness());
            contexto.Validar(novoCliente);

        }
    }
}
