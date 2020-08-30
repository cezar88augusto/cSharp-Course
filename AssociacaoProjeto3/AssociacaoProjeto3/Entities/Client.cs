using System;
using System.Collections.Generic;
using System.Text;

namespace AssociacaoProjeto3.Entities
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return
                "Nome: " + name
                + " Email: " + email
                + " BirthDate: " + birthDate.ToString("dd/MM/yyyy");
        }
    }
}
