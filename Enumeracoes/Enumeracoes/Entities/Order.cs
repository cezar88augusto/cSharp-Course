using System;
using Enumeracoes.Entities.Enums; // NÃO ESQUECER DE FAZER A IMPORTAÇÃO!!!

namespace Enumeracoes.Entities
{
    class Order
    {
        //Criar uma classe normalmente, com os atributos com o métodos getters e setteres.
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        // Definir o nome do Enum. Neste caso, é o OrderStatus e então criar o Enum. (Como se fosse um classe, mas depois tem que alterar o nome.)

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
