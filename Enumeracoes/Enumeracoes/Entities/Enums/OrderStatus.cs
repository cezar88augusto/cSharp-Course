
namespace Enumeracoes.Entities.Enums
{
    enum OrderStatus : int // Este enum é do tipo Inteiro. E deve ter o mesmo nome do atributo criado na classe pai.
    {
        PendingPayment = 0, 
        Processing = 1,
        Shipped = 2, 
        Delivered = 3
    }
}
