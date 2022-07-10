

using FashionLine.Model;

namespace FashionLine.DB.Mappings
{
    public class OrderMap : BaseEntityMap<Order>
    {
        public OrderMap()
        {
            Map(Order => Order.OrderDate);
            Map(Order => Order.DeliveryDate);
            Map(Order => Order.DeliveryAddress);
            References(Order => Order.Customer);
            //References(Order => Order.Owner);
            HasMany(Order => Order.Clothes);
            HasOne(Order => Order.PaymentInfo).PropertyRef(paymentInfo => paymentInfo.Order);                       //because the payInfo is dependent on Order

        }
    }
}
