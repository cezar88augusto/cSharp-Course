using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrybeTest;

namespace UnitTestTrybe
{
    [TestClass]
    public class UnitTest1
    {
        // Se você estár com dificuldade de escolher as próprias funções, 
        // vc está ferindo o principio da responsabilidade única!

        [TestMethod]
        public void DeveAtualizarAsPropriedadesAoCriarUmaNovaPesssoa()
        {
            // A A A - ARRANGE ACTION ASSERT
            string nome = "abc";
            uint idade = 40;
            string email = "abc@abc.com.br";

            var pessoa = new Pessoa(nome, idade, email);

            Assert.AreEqual(nome, pessoa.Nome);
            Assert.AreEqual(idade, pessoa.Idade);
            Assert.AreEqual(email, pessoa.Email);

        }

        [TestMethod]
        public void DeveAtualizarOemailQuandoPassarUmEmailValido()
        {
            string nome = "abc";
            uint idade = 40;
            string email = "abc@abc.com.br";
            var outroEmail = "def@def.com.r";

            var pessoa = new Pessoa(nome, idade, email);
            pessoa.AtualizarEmail(outroEmail);

            Assert.AreEqual(outroEmail, pessoa.Email);

        }

        [TestMethod]
        public void DeveDarUmErroCasoPasseUmEmailInvalido()
        {
            string nome = "abc";
            uint idade = 40;
            string email = "abc@abc.com.br";

            var pessoa = new Pessoa(nome, idade, email);

            Assert.ThrowsException<Exception>(() => { pessoa.AtualizarEmail(""); });
        }
    }

}
