using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Shared;

namespace UnitTestPadrao
{
    [TestClass]
    public class UnitTest1
    {
        // Projeto do tipo: Class Library .NET framework
        // Teste do tipo: Unit Test Project
        // Ir em Teste e clicar em gerenciador de testes

        [TestMethod]
        public void TestarIdadeMaior18()
        {
            int idade = 18;
            bool resultado = Helper.VerificaIdadeDeRisco(idade);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestarNomeRisco()
        {
            string nome = "corona";
            bool resultado = Helper.VerificaNomeDeRisco(nome);
            Assert.IsFalse(resultado);
        }

        //Automatizar testes como o DataRow
        [TestMethod]
        [DataRow(15)]
        [DataRow(16)]
        [DataRow(11)]
        [DataRow(80)]
        public void VerificaVariasIdades(int idade)
        {
            bool resultado = Helper.VerificaIdadeDeRisco(idade);
            Assert.IsTrue(resultado);
        }

    }
}
