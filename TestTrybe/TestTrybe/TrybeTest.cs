using System;
using System.Collections.Generic;
using System.Text;

namespace TrybeTest
{
    public class Pessoa
    {

        public Pessoa(string nome, uint idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }
        // digitar "prop" e dar tab tab
        public string Nome { get; set; }
        public uint Idade { get; set; }

        // Quem estiver do lado de fora da classe, não consegue setar o email:
        public string Email { get; private set; }

        public void AtualizarEmail(string novoEmail)
        {
            if (string.IsNullOrEmpty(novoEmail))
                throw new Exception("Email invalido");
            else Email = novoEmail;
        }

    }
}
