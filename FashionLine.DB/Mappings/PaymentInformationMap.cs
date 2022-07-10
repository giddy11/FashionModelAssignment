using FashionLine.Model;

namespace FashionLine.DB.Mappings
{
    public class PaymentInformationMap : BaseEntityMap<PaymentInformation>
    {
        public PaymentInformationMap()
        {
            Map(payment => payment.Price);
            Map(payment => payment.AmountPaid);
            //Map(payment => payment.Balance);
            References(payment => payment.Order);
        }
    }
}
