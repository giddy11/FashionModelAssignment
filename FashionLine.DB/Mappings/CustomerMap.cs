using FashionLine.Model;

namespace FashionLine.DB.Mappings
{
    public class CustomerMap : BaseEntityMap<Customer>
    {
        public CustomerMap()
        {
            Map(cust => cust.FirstName);
            Map(cust => cust.LastName);
            Map(cust => cust.Location);
            Map(cust => cust.PhoneNumber);
            HasMany(cust => cust.Orders);
        }
    }
}
