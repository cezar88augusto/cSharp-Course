using System;
using System.Collections.Generic;
using System.Text;

namespace AssociacaoProjeto3
{
    enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DILIVERED = 3,
    }
}
